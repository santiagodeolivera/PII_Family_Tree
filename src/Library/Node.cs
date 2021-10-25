using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node<T>
    {
        private T value;        

        private List<Node<T>> children = new List<Node<T>>();

        public bool IsLeaf => this.children.Count == 0;

        public T Value => this.value;

        public ReadOnlyCollection<Node<T>> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(Func<T> func)
        {
            this.value = func();
        }

        public void AddChildren(Node<T> n)
        {
            this.children.Add(n);
        }
        
        public R Accept<R>(Visitor<T, R> visitor) =>
            visitor.VisitAndReturn(this);
    }
}
