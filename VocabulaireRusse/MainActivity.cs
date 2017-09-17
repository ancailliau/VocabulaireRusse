using Android.App;
using Android.Widget;
using Android.OS;
using VocabulaireRusse.Domain;
using VocabulaireRusse.Utils;
using System.Text.RegularExpressions;
using System.Linq;

namespace VocabulaireRusse
{
    [Activity(Label = "Vocabulaire Russe", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        Button button;
        EditText editText;
        TextView textView;
        TextView strikeTextView;

        Deck deck;
        Card currentCard;
        bool GetNextCardButton;

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

            // Set up specific setting
            editText.InputType = Android.Text.InputTypes.TextVariationVisiblePassword;

            // Set up default text
            strikeTextView.Text = "";

            deck = DeckFactory.GetLRUSS1100Deck();
            GetNextCard();
            
            button.Click += Button_Click;
        }
        
        void GetNextCard ()
        {
            if (strike > 0) {
                strikeTextView.Text = $"Great, continue (strike: {strike})";
            } else if (strike == 0) {
                strikeTextView.Text = $"Ready for a great strike?";
            }
            
            currentCard = deck.PickRandom();
            textView.Text = currentCard.FrenchWord;
            editText.Text = "";
            button.Text = "Check";
            GetNextCardButton = false;
        }

        void Button_Click(object sender, System.EventArgs e)
        {
            if (GetNextCardButton) {
                GetNextCard();
                return;
            }
            
            var regex = new Regex(@"\(.*?\)");
            var answer = regex.Replace(currentCard.RussianWord, "").Split(',').Select(x => x.ToLower().Trim());
        
            // Check if edit text equals textview.
            if (answer.Contains(editText.Text.ToLower().Trim())) {
                strike++;
                button.Text = "Good! " + currentCard.RussianWord;
                GetNextCardButton = true;
            } else {
                strike = 0;
                button.Text = "KO " + currentCard.RussianWord;
                GetNextCardButton = true;
            }
        }
    }
}

