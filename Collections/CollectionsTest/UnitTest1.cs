using System;
using Xunit;
using Collections;

namespace CollectionsTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddCard()
        {
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

            Deck<CardType> myDeck = new Deck<CardType>
            {
                card1,
                card2,
           
            };

            myDeck.Add(card3);

            Assert.Equal(3, myDeck.count);
        }

        [Fact]
        public void CanSubtractCard()
        {
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

            Deck<CardType> myDeck = new Deck<CardType>
            {
                card1,
                card2,
                card3
            };

            myDeck.Subtract(card3);

            Assert.Equal(2, myDeck.count);
        }

        [Fact]
        public void CanSubtractCardThatDoesNotExist()
        {
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

            Deck<CardType> myDeck = new Deck<CardType>
            {
                card1,
                card2,
                card3
            };

            myDeck.Subtract(null);

            Assert.Equal(3, myDeck.count);
        }

        [Fact]
        public void HasProperties()
        {
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

            Deck<CardType> myDeck = new Deck<CardType>
            {
                card1,
                card2,
                card3
            };

            Assert.Equal("Spades", card1.Suite.ToString());
        }

        [Fact]
        public void CanShuffle()
        {
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

            Deck<CardType> myDeck = new Deck<CardType>
            {
                card1,
                card2,
                card3
            };

            myDeck.Shuffle();

            Assert.True(myDeck.Shuffle());
        }
    }
}
