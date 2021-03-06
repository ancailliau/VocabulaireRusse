﻿using System;
using System.Collections.Generic;
using SQLite;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace VocabulaireRusse.Domain
{
    public class Deck
    {
        [PrimaryKey,AutoIncrement]
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
        
        [OneToMany]
        public List<SubDeck> SubDecks
        {
            get;
            set;
        }
    
        public Deck()
        {
        }
    }
}
