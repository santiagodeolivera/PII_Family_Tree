namespace Library
{
    public class OldestLeafVisitor : Visitor<Person, Person>
    {
        public OldestLeafVisitor(): base(null) {}

        protected override void VisitLeaf(Person person)
        {
            if(this.result is null || this.result.Age < person.Age) this.result = person;
        }
    }
}