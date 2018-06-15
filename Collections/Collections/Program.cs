using System;
using System.Collections.Generic;


namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Deal();
            TTFN();
        }

        /// <summary>
        /// method to create deck and show working methods in console
        /// </summary>
        public static void Deal()
        {

            //each new card is initialized here
            CardType card1 = new CardType
            {
                Suite = Suite.Spades,
                Value = Value.Ace
            };

            CardType card2 = new CardType
            {
                Suite = Suite.Spades,
                Value = Value.King
            };

            CardType card3 = new CardType
            {
                Suite = Suite.Spades,
                Value = Value.Queen
            };

            CardType card4 = new CardType
            {
                Suite = Suite.Spades,
                Value = Value.Jack
            };
            CardType card5 = new CardType
            {
                Suite = Suite.Hearts,
                Value = Value.One
            };

            CardType card6 = new CardType
            {
                Suite = Suite.Hearts,
                Value = Value.Two
            };

            CardType card7 = new CardType
            {
                Suite = Suite.Hearts,
                Value = Value.Three
            };

            CardType card8 = new CardType
            {
                Suite = Suite.Hearts,
                Value = Value.Four
            };

            CardType card9 = new CardType
            {
                Suite = Suite.Clubs,
                Value = Value.Five
            };

            CardType card10 = new CardType
            {
                Suite = Suite.Clubs,
                Value = Value.Six
            };

            CardType card11 = new CardType
            {
                Suite = Suite.Clubs,
                Value = Value.Seven
            };

            CardType card12 = new CardType
            {
                Suite = Suite.Clubs,
                Value = Value.Eight
            };
            CardType card13 = new CardType
            {
                Suite = Suite.Diamonds,
                Value = Value.Nine
            };

            CardType card14 = new CardType
            {
                Suite = Suite.Diamonds,
                Value = Value.King
            };

            CardType card15 = new CardType
            {
                Suite = Suite.Diamonds,
                Value = Value.Queen
            };

            //initialized cards are put into new deck list
            Deck<CardType> myDeck = new Deck<CardType>
        {
            card1,
            card2,
            card3,
            card4,
            card5,
            card6,
            card7,
            card8,
            card9,
            card10,
            card11,
            card12,
            card13,
            card14,
            card15
        };

            //prints default deck to console
            Console.WriteLine("--Default Deck--");

            foreach(var item in myDeck)
            {
                Console.WriteLine($"{item.Suite} {item.Value}");
            }

            //shuffles deck and prints new deck to console
            myDeck.Shuffle();

            Console.WriteLine("----------------------------");
            Console.WriteLine("--Shuffled deck--");

            foreach (var item in myDeck)
            {
                Console.WriteLine($"{item.Suite} {item.Value}");
            }

            CardType card16 = new CardType
            {
                Suite = Suite.Clubs,
                Value = Value.Ace
            };

            //adds new card to deck and prints new deck to console
            myDeck.Add(card16);

            Console.WriteLine("----------------------------");
            Console.WriteLine("--Deck with new added card at the bottom--");

            foreach (var item in myDeck)
            {
                Console.WriteLine($"{item.Suite} {item.Value}");
            }

            //subtracts new card from deck and prints new deck to console
            myDeck.Subtract(card16);

            Console.WriteLine("----------------------------");
            Console.WriteLine("--Deck with new card subtracted from bottom--");

            foreach (var item in myDeck)
            {
                Console.WriteLine($"{item.Suite} {item.Value}");
            }
        }

        public static void TTFN()
        {
            Console.WriteLine("Thanks for visiting.");
            Console.WriteLine("Press any key to exit.");
        }
    }
}
