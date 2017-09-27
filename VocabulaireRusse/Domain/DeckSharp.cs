using System;
using System.Collections.Generic;

namespace VocabulaireRusse.Domain
{
    public class DeckSharp
    {
        List<Card> cards;
        Random r;
        
        public DeckSharp()
        {
            cards = new List<Card>();
            r = new Random((int)DateTime.Now.Ticks);
        }
        
        public Card PickRandom ()
        {
            var index = r.Next(0, cards.Count);
            return cards[index];
        }
        
        public void Add (Card c)
        {
            cards.Add(c);
        }

        internal IEnumerable<Card> GetCards()
        {
            return cards;
        }
    }
}
