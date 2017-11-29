using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading;

namespace System.Collections.Immutable
{
    public class ImmutableList<T> : IImmutableList<T>
    {
        internal static readonly ImmutableList<T> Empty = new ImmutableList<T>();
        readonly AvlNode<T> root = AvlNode<T>.Empty;
        readonly IEqualityComparer<T> valueComparer;

        internal ImmutableList()
        {
            this.valueComparer = EqualityComparer<T>.Default;
        }

        internal ImmutableList(AvlNode<T> root, IEqualityComparer<T> equalityComparer)
        {
            this.root = root;
            this.valueComparer = equalityComparer;
        }

        public T Head()
        {
            throw new NotImplementedException();
        }

        public T Tail()
        {
            throw new NotImplementedException();
        }

        public IImmutableList<T> Cons(T item)
        {
            return new ImmutableList<T>(root.InsertIntoNew(0, item), valueComparer);
        }

        public IImmutableList<T> Drop(int count)
        {
            var result = this;
            while (count-- > 0)
            {
                bool found;
                result = new ImmutableList<T>(root.RemoveFromNew(0, out found), valueComparer);
            }
            return result;
        }

        public IImmutableList<T> Reverse()
        {
            throw new NotImplementedException();
        }
    }

    public static class ImmutableList
    {
        public static ImmutableList<T> Create<T>()
        {
            return ImmutableList<T>.Empty;
        }
    }
}
