using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace Collections
{
    public class CardType
    {
        /// <summary>
        /// getters and setters for card values
        /// </summary>
        public Suite Suite { get; set; }
        public Value Value { get; set; }

    }

    /// <summary>
    /// enumerator values for Suite type
    /// </summary>
    public enum Suite
    {
        Hearts,
        Diamonds,
        Spades,
        Clubs
    }

    /// <summary>
    /// enumerator values for Value type
    /// </summary>
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
