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

        public void Subtract(T item)
        {

        }

        public void Shuffle()
        {

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
