namespace Library
{
    public class LongestNameVisitor : Visitor<Person, Person>
    {
        public LongestNameVisitor(): base(null) {}

        protected override void VisitNode(Person person)
        {
            if(this.result is null || this.result.Name.Length < person.Name.Length)
                this.result = person;
        }
    }
}