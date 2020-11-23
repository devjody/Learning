using System;

namespace Records_Example_dotnet5
{
    class Program
    {
        static void Main(string[] args)
        {
            RecordExample recZ = new("Jimmy", "Boston");
            RecordExample recA = new("Jimmy", "Boston");
            RecordExample recB = new("Jenny", "Smith");
            RecordExample recC = new("Indi", "Clark");
            
            ClassExample claZ = new("Jimmy", "Boston");
            ClassExample claA = new("Jimmy", "Boston");
            ClassExample claB = new("Jenny", "Smith");
            ClassExample claC = new("Indi", "Clark");

            //Console.WriteLine("Record Type");
            //Console.WriteLine($"To String: { recZ }");
            //Console.WriteLine($"Are these objects equal? { Equals( recZ, recA) }");
            //Console.WriteLine($"Are these objects equal ==? { (recZ == recA) }");
            //Console.WriteLine($"Are these objects ref equal? { ReferenceEquals( recZ, recA) }");
            //Console.WriteLine($"Hash code of object Z: {recZ.GetHashCode() }");
            //Console.WriteLine($"Hash code of object A: {recA.GetHashCode() }");
            //Console.WriteLine($"Hash code of object B: {recB.GetHashCode() }");
            //Console.WriteLine($"Hash code of object C: {recC.GetHashCode() }");

            //Console.WriteLine("\n============================\n");

            //Console.WriteLine("Class Type");
            //Console.WriteLine($"To String; { claZ }");
            //Console.WriteLine($"Are these objects equal? { Equals(claZ, claA) }");
            //Console.WriteLine($"Are these objects equal ==? { (claZ == claA) }");
            //Console.WriteLine($"Are these objects ref equal? { ReferenceEquals(claZ,claA) }");
            //Console.WriteLine($"Hash code of object Z: {claZ.GetHashCode() }");
            //Console.WriteLine($"Hash code of object A: {claA.GetHashCode() }");
            //Console.WriteLine($"Hash code of object B: {claB.GetHashCode() }");
            //Console.WriteLine($"Hash code of object C: {claC.GetHashCode() }");

            //Console.WriteLine("\n============================\n");

            //var (first, last) = recZ; // Deconstructing back to assignment
            //Console.WriteLine($"The value of first is {first}");
            //Console.WriteLine($"The value of last is {last}");

            //RecordExample recD = recC with
            //{
            //    LastName = "Thomson"
            //}; // Makes a copy and changes an entry in copy
            //Console.WriteLine($"Miss Thomson's record is { recD }");

            //Console.WriteLine("\n============================\n");

            RecordExample2 rex2A = new("John", "Doe");
            Console.WriteLine($"rex2A value is : {rex2A}");
            Console.WriteLine($"rex2A firstname is : {rex2A.FirstName} and lastname is : {rex2A.LastName}");
            Console.WriteLine($"The full name is {rex2A.FullName}");
            Console.WriteLine(rex2A.SayHello());

            // Inheritance example...
            Person person = new( 1, "Santa", "Clause" );
            Console.WriteLine($"Person value's are : {person}");

            /*
             * Benefits of Records - Simple, ThreadSafe, Easy to share
             * When to use them - When working with data that doesn't change
             * */

            Console.ReadLine();
        }
    }

    public record RecordExample(string FirstName, string LastName);
    // Read Only and Immutable, objects are value type

    // How it inheritance with records...
    public record Person(int Id, string FirstName, string LastName) : RecordExample(FirstName, LastName);

 
    public record RecordExample2(string FirstName, string LastName)
    {
        private string _firstName = FirstName;

        public string FirstName
        {
            get { return _firstName.Substring(0, 3); }
            init { }
        }

        //internal string FirstName { get; init; } = FirstName;
        public string FullName { get => $"{FirstName} {LastName}"; }

        public string SayHello()
        {
            return $"Hi there, {FullName}";
        }
    }
    // Read Only and Immutable, objects are value type
    
    public class ClassExample
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public ClassExample(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public void Deconstruct(out string FirstName, out string LastName)
        {
            FirstName = this.FirstName;
            LastName = this.LastName;
        }
    }
}
