using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Lifetime;

namespace Assignment12
{
    internal class Program
    {
        public static int count(string sentence)
        {
            string[] words=sentence.Split(' ');
            return words.Length;
        }
        public static List<string> emailValidation(string sentence)
        {
            String pattern = "[a-zA-Z0-9]+@[a-zA-Z0-9]+(\\.[a-zA-Z0-9]+)$";
            Regex regex = new Regex(pattern);
            string[] words = sentence.Split(' ');
            List<string> result = new List<string>();
            foreach(string word in words)
            {
                if (regex.IsMatch(word))
                    result.Add(word);
            }
            return result;
        }
        public static List<string> numberValidation(string sentence)
        {
            string pattern = "(0/+91)?[0-9]{10}";
            Regex regex = new Regex(pattern);
            string[] words = sentence.Split(' ');
            List<string> result = new List<string>();
            foreach (string word in words)
            {
                if (regex.IsMatch(word))
                    result.Add(word);
            }
            return result;
        }
        public static List<string> customValidation(string sentence)
        {
            Console.WriteLine("Enter the Regex pattern to find the sequence");
            string pattern = Console.ReadLine();
            Regex regex = new Regex(pattern);
            string[] words = sentence.Split(' ');
            List<string> result = new List<string>();
            foreach (string word in words)
            {
                if (regex.IsMatch(word))
                    result.Add(word);
            }
            return result;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the String");
                string userInput = Console.ReadLine();
                if (userInput.Length == 0)
                {
                    Console.WriteLine("It is an empty string");
                    return;
                }
                List<string> email = emailValidation(userInput);
                List<string> number = numberValidation(userInput);
                List<string> custom = customValidation(userInput);
                Console.WriteLine("No of words in the sentence is " + count(userInput));
                Console.WriteLine();
                if (email.Count != 0) 
                {
                    Console.WriteLine("The Mail Id's are :");
                    foreach (string mail in email)
                    {
                        Console.WriteLine("\t" + mail);
                    }
                    Console.WriteLine();
                }
                if (number.Count != 0)
                {
                    Console.WriteLine("The Numbers are :");
                    foreach (string num in number)
                    {
                        Console.WriteLine("\t" + num);
                    }
                    Console.WriteLine();
                }
                if (custom.Count != 0)
                {

                    Console.WriteLine("The Custom check result are :");
                    foreach (string cust in custom)
                    {
                        Console.WriteLine("\t" + cust);
                    }
                }
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
//Please events@com send the package jane.doeemail.com to 123 Main Street, Bangalore, 560001, INDIA. You can support@example.com CONTACT me at +91-9876543210 or email me at john.doe@email.com The PIN code for the nearby post office is 560011 9998887776 