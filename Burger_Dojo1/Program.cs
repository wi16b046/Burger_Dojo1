using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burger_Dojo1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestString();
            TestInt();
            TestPerson();
            
        }

        static void TestString()
        {
            Console.WriteLine("\nTEST WITH STRING\n");
            Stack<string> testStack = new Stack<string>();

            testStack.Push("Welt");
            Console.WriteLine("\nItem added");
            testStack.Push("Hallo");
            Console.WriteLine("\nItem added");
            Console.WriteLine("\nPeek: " + testStack.Peek());
            Console.WriteLine("\n{0} was removed", testStack.Pop());
            Console.WriteLine("\nPeek: " + testStack.Peek());
            Console.WriteLine("\n{0} was removed", testStack.Pop());

            /*Would throw NullReferenceException because Stack is empty
            Console.WriteLine("Peek: " + testStack.Peek() + "\n");
            Console.WriteLine("{0} was removed\n", testStack.Pop());*/

            testStack.Push("Hallo Welt!");
            Console.WriteLine("\nItem added");
            Console.WriteLine("\nPeek: " + testStack.Peek());
            
        }

        static void TestInt()
        {
            Console.WriteLine("\nTEST WITH INT\n");
            Stack<int> testStack = new Stack<int>();

            testStack.Push(25);
            Console.WriteLine("\nItem added");
            testStack.Push(50);
            Console.WriteLine("\nItem added");
            Console.WriteLine("\nPeek: " + testStack.Peek());
            Console.WriteLine("\n{0} was removed", testStack.Pop());
            Console.WriteLine("\nPeek: " + testStack.Peek());
            Console.WriteLine("\n{0} was removed", testStack.Pop());

            /*Would throw NullReferenceException because Stack is empty
            Console.WriteLine("Peek: " + testStack.Peek() + "\n");
            Console.WriteLine("{0} was removed\n", testStack.Pop());*/

            testStack.Push(75);
            Console.WriteLine("\nItem added");
            Console.WriteLine("\nPeek: " + testStack.Peek());
        }

        static void TestPerson()
        {
            Console.WriteLine("\nTEST WITH PERSON\n");
            Stack<Person> testStack = new Stack<Person>();
            Person p1 = new Person(21, "Christoph", "Burger");
            Person p2 = new Person(33, "John", "Doe");
            Person p3 = new Person(18, "Sabine", "Musterfrau");

            testStack.Push(p1);
            Console.WriteLine("\nItem added");
            testStack.Push(p2);
            Console.WriteLine("\nItem added");
            Console.WriteLine("\nPeek: " + testStack.Peek());
            Console.WriteLine("\n{0} was removed", testStack.Pop());
            Console.WriteLine("\nPeek: " + testStack.Peek());
            Console.WriteLine("\n{0} was removed", testStack.Pop());

            /*Would throw NullReferenceException because Stack is empty
            Console.WriteLine("Peek: " + testStack.Peek() + "\n");
            Console.WriteLine("{0} was removed\n", testStack.Pop());*/

            testStack.Push(p3);
            Console.WriteLine("\nItem added");
            Console.WriteLine("\nPeek: " + testStack.Peek());

        }
    }
}
