using Android.App;
using Android.Widget;
using Android.OS;
using VocabulaireRusse.Domain;
using VocabulaireRusse.Utils;
using System.Text.RegularExpressions;
using System.Linq;
using SQLite;
using System.IO;
using SQLite.Net;
using SQLite.Net.Platform.XamarinAndroid;

namespace VocabulaireRusse
{
    [Activity(Label = "да!", MainLauncher = true, Icon = "@mipmap/ic_launcher", Theme = "@android:style/Theme.Holo.Light")]
    public class MainActivity : Activity
    {
        Button button;
        EditText editText;
        TextView textView;
        TextView strikeTextView;
        TextView cardStatisticsTV;

        //Deck deck;
        Card currentCard;
        bool GetNextCardButton;

        SQLiteConnection connection;

        int strike = 0;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            button = FindViewById<Button>(Resource.Id.myButton);
            editText = FindViewById<EditText>(Resource.Id.myEditText);
            textView = FindViewById<TextView>(Resource.Id.myTextView);
            strikeTextView = FindViewById<TextView>(Resource.Id.strikeTextView);
            cardStatisticsTV = FindViewById<TextView>(Resource.Id.cardStatisticsTV);

            // Set up specific setting
            editText.InputType = Android.Text.InputTypes.TextVariationVisiblePassword;

            // Set up default text
            strikeTextView.Text = "";
            
            // Connect to the database
            string dbPath = Path.Combine (
                System.Environment.GetFolderPath (System.Environment.SpecialFolder.Personal),
                "french-russian.db3"
            );
            createDatabase(dbPath);

            GetNextCard();

            button.Click += Button_Click;
        }

        void GetNextCard()
        {
            if (strike > 0)
            {
                strikeTextView.Text = $"Great, continue (strike: {strike})";
            }
            else if (strike == 0)
            {
                strikeTextView.Text = $"Ready for a great strike?";
            }
            
            editText.SetTextColor(Android.Graphics.Color.Black);

            var cc = connection.Query<Card>(
                @"SELECT Card.* FROM Card 
                  JOIN SubDeck ON SubDeck.Id = Card.SubDeckId 
                  WHERE SubDeck.IsActive
                  ORDER BY RANDOM()
                  LIMIT 1").First();
            System.Console.WriteLine(cc);
            currentCard = cc; //deck.PickRandom();

            cardStatisticsTV.Text = $"({currentCard.NbSuccess}/{currentCard.NbSuccess + currentCard.NbFailure})";
            
            textView.Text = currentCard.FrenchWord;
            editText.Text = "";
            button.Text = "Check";
            GetNextCardButton = false;
        }

        void Button_Click(object sender, System.EventArgs e)
        {
            if (GetNextCardButton)
            {
                GetNextCard();
                return;
            }

            var regex = new Regex(@"\(.*?\)");
            var answer = regex.Replace(currentCard.RussianWord, "").Split(',').Select(x => x.ToLower().Trim());

            // Check if edit text equals textview.
            if (answer.Contains(editText.Text.ToLower().Trim()))
            {
                strike++;
                button.Text = "Next";
                editText.Text = currentCard.RussianWord;
                editText.SetTextColor(new Android.Graphics.Color(48,144,68));//#309044
                currentCard.NbSuccess++;
                connection.Update(currentCard);
                GetNextCardButton = true;
            }
            else
            {
                strike = 0;
                button.Text = "Next";
                editText.Text = currentCard.RussianWord;
                editText.SetTextColor(new Android.Graphics.Color(254, 75, 51));
                currentCard.NbFailure++;
                connection.Update(currentCard);
                GetNextCardButton = true;
            }
        }

        private string createDatabase(string path)
        {
            try
            {
                connection = new SQLiteConnection(new SQLitePlatformAndroid(), path);
                connection.DropTable<Deck>();
                connection.DropTable<SubDeck>();
                connection.DropTable<Card>();
                
                connection.CreateTable<Deck>();
                connection.CreateTable<SubDeck>();
                connection.CreateTable<Card>();
                var d = DeckFactory.CreateTestDeck(connection);
                return "Database created";
            }
            catch (SQLiteException ex)
            {
                return ex.Message;
            }
        }
    }
}

