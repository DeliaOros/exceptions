using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myStringList = new List<string>();
            myStringList.Add("C#");
            myStringList.Add("Java");
            myStringList.Add("Python");
            myStringList.Add("C++");
            foreach (var item in myStringList)
            {
                Console.WriteLine(item);
            }
            if (myStringList.Contains("Java"))
            {
                myStringList.Remove("Java");
            }
            Zoo myAwsomeZoo = new Zoo();

            foreach(var animal in myAwsomeZoo.Animals)
            {
                Console.WriteLine($"This is a {animal.Name} and its a {animal.Gender}");
            }
        }
    }
}
