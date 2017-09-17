using System;
namespace VocabulaireRusse.Domain
{
    public class Card
    {
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
    
        public Card(string russianWord, string frenchWord)
        {
            RussianWord = russianWord;
            FrenchWord = frenchWord;
        }
    }
}
