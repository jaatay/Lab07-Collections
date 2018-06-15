using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    public class Deck<T> : IEnumerable<T>
    {
        T[] items = new T[16];

        int count;

        /// <summary>
        /// add card to deck
        /// </summary>
        /// <param name="item">what card to add to deck</param>
        /// 
        public void Add(T item)
        {
            if (count == items.Length)
            {
                Array.Resize(ref items, items.Length * 2);
            }

            items[count++] = item;
        }

        /// <summary>
        /// subtracts last card from the array
        /// </summary>
        /// <param name="item">a enumerable type item</param>
        public void Subtract(T item)
        {
            items[--count] = item;
            Array.Resize(ref items, items.Length - 1);
           
        }

        /// <summary>
        /// shuffles deck based on random index numbers
        /// </summary>
        public void Shuffle()
        {
            for (int i = 0; i < count; i++)
            {
                Random random = new Random();
                int randomNumber = random.Next(0, count);

                items[i] = items[randomNumber];
            }
        }

        /// <summary>
        /// enumerator interface
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        /// <summary>
        /// magic method
        /// </summary>
        /// <returns>hocus pocus</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
