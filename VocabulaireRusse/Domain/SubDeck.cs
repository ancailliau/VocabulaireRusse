using System;
using System.Collections.Generic;
using SQLite;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace VocabulaireRusse.Domain
{
    public class SubDeck
    {
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        [ForeignKey(typeof(Deck))]
        public int DeckId
        {
            get;
            set;
        }

        public bool IsActive
        {
            get;
            set;
        }

        [OneToMany]
        public List<Card> Cards
        {
            get;
            set;
        }

        public SubDeck()
        {
        }
    }
}
