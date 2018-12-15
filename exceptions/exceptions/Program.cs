using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int b = 100;
                int a = b / 0;
                Console.WriteLine(a);

            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine("Ooops!Something happened.");
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.StackTrace);
            }
            try
            {
                Person person = new Person(15);
                Person person1 = new Person(-1);
                Person person2 = new Person(2);
                Person person3 = new Person(81);
            }

            catch (ArgumentException e)
            {


                //this will show an error
                //cw        e
                Console.WriteLine(e.Message + e.GetType());

                //throw;
            }
            catch (DressCodeException ex)
            {
                Console.WriteLine(ex.Message + ex.GetType());

            }

            Dictionary <string, decimal> dict = new Dictionary<string, decimal>();
            dict.Add("Gigi", 30.23m);
            dict.Add("Ion", 37.23m);
            dict.Add("Craciun", 50.23m);

            foreach(var record in dict)
            {
                Console.WriteLine($"{record.Key}:{record.Value}");
            }










        }


    }
}

