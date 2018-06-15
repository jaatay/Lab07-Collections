using System;
using System.Collections.Generic;


namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Deal();
        }

        /// <summary>
        /// card creation
        /// </summary>
        /// 
        static void Deal()
        {

            //initialize
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

            Console.WriteLine("--Default Deck--");

            foreach(var item in myDeck)
            {
                Console.WriteLine($"{item.Suite} {item.Value}");
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("--Shuffled deck--");


            //shuffle
            myDeck.Shuffle();

            foreach (var item in myDeck)
            {
                Console.WriteLine($"{item.Suite} {item.Value}");
            }

            CardType card16 = new CardType
            {
                Suite = Suite.Clubs,
                Value = Value.Ace
            };


            //add
            myDeck.Add(card16);

            Console.WriteLine("--Deck with added card--");

            foreach (var item in myDeck)
            {
                Console.WriteLine($"{item.Suite} {item.Value}");
            }

            //subtract
            myDeck.Subtract(card16);

            Console.WriteLine("--Deck with subtracted card--");

            foreach (var item in myDeck)
            {
                Console.WriteLine($"{item.Suite} {item.Value}");
            }
        }
    }
}
