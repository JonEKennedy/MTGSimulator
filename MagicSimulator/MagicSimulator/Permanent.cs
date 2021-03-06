﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MagicSimulator.Enums;

namespace MagicSimulator
{
    public abstract class Permanent : Card
    {
        //tapped , counters, etc
        public bool Tapped { get; private set; }
        List<Counter> Counters;

        public Permanent(string name, CardType type, string cost = "{0}", Color color = Color.Colorless, Color identity = Color.Colorless, Supertype supertype = Supertype.None, 
            string[] subtypes = null, string artist = "", string number = "", string text = "", string set = "", Rarity rarity = Rarity.Common, 
            Keyword[] keywords = null, int multiverseId = 0, string imageUrl = "", Ruling[] rulings = null, bool tapped = false, List<Counter> counters = null) 
            : base(name, type | CardType.Permanent, cost, color, identity, supertype, subtypes, artist, number, text, set, rarity, keywords, multiverseId, imageUrl, rulings)
        {
            Counters = counters ?? new List<Counter>();
        }

        public void Tap()
        {
            Tapped = true;
        }
        public void Untap()
        {
            Tapped = false;
        }

        public override string ToString()
        {
            return Name + (Tapped ? ", Tapped" : "");
        }

    }
}
