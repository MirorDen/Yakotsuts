using System;

namespace PZ2New_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class client
    {
        private int age;
        private string name;
        private string familia;

        //constructor
        public client()
        {
            name = "N/A";
        }
        //constructor
        public client(string name, string familia, int age)
        {
            this.name = name;
            this.familia = familia;
            this.age = age;
        }
        //printhing method
        public void Printclient()
        {
            Console.WriteLine("{0}, {0}, {1} years old.", name, familia, age);
        }
    }
    class StringTest
    {
        static void Main()
        {
            // Create objects by using the new operator:
            client client1 = new client("Ivan", "Zervov", 18);
            client client2 = new client("Danil", "Yakotsuts", 18);

            // Create an object using the default constructor:
            client client3 = new client();

            // Display results:
            Console.Write("Child #1: ");
            client1.Printclient();
            Console.Write("Child #2: ");
            client2.Printclient();
            Console.Write("Child #3: ");
            client3.Printclient();
        }
    }
    public class Mesto
    {
        // Constructor that takes no arguments:
        public Mesto()
        {
            Name = "unknown";
        }

        // Constructor that takes one argument:
        public Mesto(string name)
        {
            Name = name;
        }

        // Auto-implemented readonly property:
        public string Name { get; }

        // Method that overrides the base class (System.Object) implementation.
        public override string ToString()
        {
            return Name;
        }
    }
    class TestPerson
    {
        static void Main()
        {
            // Call the constructor that has no parameters.
            var mesto1 = new Mesto();
            Console.WriteLine(mesto1.Name);

            // Call the constructor that has one parameter.
            var mesto2 = new Mesto("Krasnoyarsk");
            Console.WriteLine(mesto2.Name);
            // Get the string representation of the person2 instance.
            Console.WriteLine(mesto2);
        }
    }
}


