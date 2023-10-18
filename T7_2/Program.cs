using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Task 1.
                //The name of a soccer club is given. Find the quantity of symbols in it.

                /*Write("Enter the name of a soccer club: ");     //Ask user to enter a name of soccer club
                string socclub = ReadLine();
                WriteLine($"\nThe quantity of symbols in it: {socclub.Length}");*/        //Find the quantity of symbol using the .Length


                //Task 2.
                //The name of a city is given. Find out if the number of symbols in it is even or odd.

                /*Write("Enter the name of a city: ");     //Ask user to enter a name of city
                string city = ReadLine();
                WriteLine($"\nThe quantity of symbols in it: {city.Length}");   //Find the quantity of symbol using the .Length
                string compare = city.Length % 2 == 0 ? "It's an even number" : "It's an odd number";   //Find out if the number of symbols in it is even or odd using the ternary operator
                WriteLine(compare);*/


                //Task 3.
                //Two surnames are given. Find out which one is longer.

                /*Write("Enter the first surname: ");     //Ask user to enter surnames
                string surname_1 = ReadLine();
                Write("Enter the second surname: ");
                string surname_2 = ReadLine();

                if(surname_1.Length > surname_2.Length)     //Use nested condition operator
                {
                    WriteLine("The first name is longer.");
                }
                else if (surname_1.Length < surname_2.Length)
                {
                    WriteLine("The second name is longer.");
                }
                else if (surname_1.Length == surname_2.Length)
                {
                    WriteLine("The surnames are the same length.");
                }*/


                //Task 4.
                //Find the longest word out of five words entered from the keyboard.

                /*string[] words = new string[5];     //Enter array
                string longest = " ";
                for (int i = 0; i < 5; i++)         //Complete the array using the cycle for
                {
                    Write($"Enter the {i+1} word: ");
                    words[i] = ReadLine();
                }
                foreach(string word in words)           //Enumerate and compare array elements
                {
                    if (word.Length > longest.Length)
                    {
                        longest = word;
                    }
                }
                WriteLine($"\nThe longest word: {longest}");*/   //Output the longest word


                //Task 5.
                //Make a program that asks for first name and last name separately, and then outputs them as a single symbolic string.

                /*Write("Enter the first name: ");
                string firstname = ReadLine();
                Write("Enter the last name: ");
                string lastname = ReadLine();
                firstname += lastname;
                WriteLine(firstname);*/


                //Task 6.
                //Count the number of letters "a"("A") in the string.

                /*Write("Enter a word: ");
                string word = ReadLine();
                int letter_a = word.Split('a', 'A', 'а', 'А').Length - 1;
                WriteLine($"\nThe number of letters: {letter_a}");*/


                //Task 7.
                //Count the quantity of words in a sentence, given that each word is separated from another by a space.

                /*Write("Enter a sentence: ");
                string sentence = ReadLine();
                int words = sentence.Split(' ').Length;
                WriteLine($"\nThe quantity of words: {words}");*/


            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
