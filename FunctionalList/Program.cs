using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalList
{
    class Program
    {
        static void Main(string[] args)
        {
            ImmutableList<int> list = ImmutableList.Create<int>();
            IImmutableList<int> list2 = list.Cons(5);
            int headvalue = list2.Head();
            int tailvalue = list2.Tail();

            IImmutableList<int> list3 = list2.Drop(2);
            IImmutableList<int> list4 = list3.Reverse();

        }
    }
}
