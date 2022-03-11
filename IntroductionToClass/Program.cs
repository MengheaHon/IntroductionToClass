using System;

namespace IntroductionToClass
{
    class TestPerson
    {
        static void Main(string[] args)
        {
            // Call the contructor that has no param
            var person1 = new Person();
            Console.WriteLine(person1.Name);
            // Call the contructor that has one param
            var person2 = new Person("John Doe");
            Console.WriteLine(person2.Name);
            // Get the string representation of the person2 instance.
            Console.WriteLine(person2);
        }
    }
}
//output
// unknow
// John Doe
// John Doe