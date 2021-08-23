using System;
using System.Collections.Generic;

namespace Delegate
{
    public delegate void Print(string word);
    public delegate string Test();

    class Program
    {
        static void Main(string[] args)
        {
            #region Delegate

            //int[] numbers = { 1, 2, 3, 4, 5 };
            //Sum(numbers);
            //Console.WriteLine(Delegates.Sum(IsEven, 1, 2, 3, 4, 5)); 
            //Console.WriteLine(Delegates.Sum(IsOdd, 1, 2, 3, 4, 5, 10)); 
            //Console.WriteLine(Delegates.Sum(MoreThanFive, 1, 2, 3, 4, 5, 6, 7));

            //Lambda expression - anonymous method
            //Console.WriteLine(Delegates.Sum((x => x < 4 && x > 1), 1, 2, 3, 4));
            //Console.WriteLine(Delegates.Sum2(1, 2, 3, 4, 5)); 

            //Print print = new Print(PrintToUpper);
            //Print print = PrintToUpper;
            //print += PrintToLower;
            //print += PrintFirstChar;
            //print += (a) => Console.WriteLine("Word: " + a);
            //print += PrintWord;
            //print("Salam");
            //print.Invoke("Salam");
            //print -= PrintToLower;
            //print("Sagol");

            //Test test = Welcome;
            //test += Bye;
            //test += () =>
            //{
            //    Console.WriteLine("Welcome");
            //    return "Welcome";
            //};
            //test();

            //Action<string> print = PrintToUpper;
            //print += PrintToLower;
            //print += PrintFirstChar;
            //print("Salam");

            //Predicate<int> check = IsEven;
            //Console.WriteLine(Delegates.Sum(IsEven, 1, 2, 3, 4, 5));

            //Func<string> func = Welcome;

            //List<int> numbers = new List<int>();
            //numbers.Add(1);
            //numbers.Add(3);
            //numbers.Add(4);
            //numbers.Add(6);

            //Console.WriteLine(numbers.Find(x => x == 3)); 

            //List<Person> people = new List<Person>();
            //people.Add(new Person(1, "Fagan"));
            //people.Add(new Person(2, "Rail"));
            //people.Add(new Person(3, "Sarkhan"));
            //people.Add(new Person(4, "Ulvi"));
            //Console.WriteLine(people.Find(person => person.Id == 3)); 
            //Console.WriteLine(people.Find(person => person.Name == "Ulvi"));
            //Person person = people.Find(person => person.Name == "Elnur");
            //if (person == null)
            //    Console.WriteLine("Bele adda person yoxdur."); 

            #endregion
        }

        static string Welcome()
        {
            Console.WriteLine("Hello");
            return "Hello ";
        }

        static string Bye()
        {
            Console.WriteLine("Bye");
            return "Bye ";
        }

        //static void PrintWord(string a)
        //{
        //    Console.WriteLine("Word: " + a);
        //}

        static void PrintToUpper(string word)
        {
            Console.WriteLine("Upper: " + word.ToUpper());
        }

        static void PrintToLower(string word)
        {
            Console.WriteLine("Lower: " + word.ToLower());
        }

        static void PrintFirstChar(string word)
        {
            Console.WriteLine("First char: " + word[0]);
        }

        static bool IsEven(int item)
        {
            return item % 2 == 0;
        }

        static bool IsOdd(int item)
        {
            return item % 2 != 0;
        }

        static bool MoreThanFive(int item)
        {
            return item > 5;
        }
    }
}
