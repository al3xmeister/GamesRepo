using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.CardGame
{
    public class PackShuffler : IPackOfCards
    {
        public int Count => throw new NotImplementedException();

        public IEnumerator<ICard> GetEnumerator() => throw new NotImplementedException();
        public void Shuffle() => throw new NotImplementedException();
        public ICard TakeCardFromTopOfPack() => throw new NotImplementedException();
        IEnumerator IEnumerable.GetEnumerator() => throw new NotImplementedException();
    }
}
