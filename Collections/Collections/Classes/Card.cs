using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace Collections
{
    public class CardType
    {
        
        public Suite Suite { get; set; }
        public Value Value { get; set; }
       

      
    }

    public enum Suite
    {
        Hearts,
        Diamonds,
        Spades,
        Clubs
    }

    public enum Value
    {
        One = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Jack = 10,
        Queen,
        King,
        Ace
    }
}
