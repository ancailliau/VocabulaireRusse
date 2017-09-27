using System;
using SQLite;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;
namespace VocabulaireRusse.Domain
{
    public class Card
    {
        [PrimaryKey,AutoIncrement]
        public int Id
        {
            get;
            set;
        }
       
        public string RussianWord
        {
            get;
            set;
        }

        public string FrenchWord
        {
            get;
            set;
        }
        
        public int NbSuccess
        {
            get;
            set;
        }
        
        public int NbFailure
        {
            get;
            set;
        }
        
        [ForeignKey(typeof(SubDeck))]
        public int SubDeckId
        {
            get;
            set;
        }
        
        public Card()
        {
        }

        public Card(string russianWord, string frenchWord)
        {
            RussianWord = russianWord;
            FrenchWord = frenchWord;
            NbSuccess = 0;
            NbFailure = 0;
        }
        
        public override string ToString()
        {
            return string.Format("[Card: Id={0}, RussianWord={1}, FrenchWord={2}, NbSuccess={3}, NbFailure={4}]", Id, RussianWord, FrenchWord, NbSuccess, NbFailure);
        }
    }
}
