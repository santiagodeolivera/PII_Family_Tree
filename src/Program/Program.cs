using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<Person> n1 = new Node<Person>(() => new Person("Robert", 60));
            Node<Person> n2 = new Node<Person>(() => new Person("Juliana", 35));
            Node<Person> n3 = new Node<Person>(() => new Person("María", 38));
            Node<Person> n4 = new Node<Person>(() => new Person("John", 10));
            Node<Person> n5 = new Node<Person>(() => new Person("Susan", 15));
            Node<Person> n6 = new Node<Person>(() => new Person("José", 12));
            Node<Person> n7 = new Node<Person>(() => new Person("Camilo", 14));

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            {
                int totalAge = n1.Accept(new AgeSumVisitor());
                Console.WriteLine($"Age sum: {totalAge}");
            }
            {
                Person oldestLeaf = n1.Accept(new OldestLeafVisitor());
                Console.WriteLine($"Oldest childless person: {oldestLeaf.Name}, {oldestLeaf.Age} year(s) old.");
            }
            {
                Person longestNamePerson = n1.Accept(new LongestNameVisitor());
                Console.WriteLine($"Person with longest name: {longestNamePerson.Name}");
            }
        }
    }
}
