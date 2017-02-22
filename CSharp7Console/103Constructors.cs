namespace CSharp7Console
{
    //Been pushed back to c#8

    public class Person
    {
 
        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public int Age { get; private set; }

        public string Name { get; private set; }
    }

    //Record Type
    //public class PersonRecordType(int Age, int Name);
    

    public class Constructor
    {
        public static void ConstructorExample()
        {
            Person inigo = new Person("Inigo Montoya", 42);
            //Person humperdink = inigo with { Name = "Prince Humperdink" };
        }
    }
}
