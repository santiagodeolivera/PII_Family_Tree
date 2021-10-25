using System;

namespace Library
{
    public abstract class Visitor<T, R>
    {
        protected R result;

        public Visitor(R defaultValue)
        {
            this.result = defaultValue;
        }

        protected virtual void VisitNode(T value)
        {
        }

        protected virtual void VisitLeaf(T value)
        {
        }

        public R VisitAndReturn(Node<T> mainNode)
        {
            this.Visit(mainNode);
            return result;
        }

        public void Visit(Node<T> node)
        {
            this.VisitNode(node.Value);
            if(node.IsLeaf) this.VisitLeaf(node.Value);
            foreach(Node<T> child in node.Children) this.Visit(child);
        }
    }
}