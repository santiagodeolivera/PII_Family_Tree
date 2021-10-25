namespace Library
{
    public class AgeSumVisitor : Visitor<Person, int>
    {

        public AgeSumVisitor(): base(0) {}

        protected override void VisitNode(Person person)
        {
            this.result += person.Age;
        }
    }
}