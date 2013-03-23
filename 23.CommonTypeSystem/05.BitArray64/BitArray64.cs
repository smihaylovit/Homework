using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.BitArray64
{
    class BitArray64 : IEnumerable<int>
    {
        private ulong bits;
        private ulong mask=1;

        public BitArray64(ulong input)
        {
            this.bits = input;
        }

        //implementing indexer
        public int this[int indexer]
        {
            get
            {
                return ((mask << indexer) & bits) > 0 ? 1 : 0;
            }
        }

        //implementing IEnumerable
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 63; i >=0; i--)
            {
                yield return ((mask << i) & bits) > 0 ? 1 : 0;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
