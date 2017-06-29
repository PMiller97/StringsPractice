using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstName = "Paige";
            //int lengthOfName = firstName.Length;
            //Console.WriteLine(lengthOfName);
            ////when printed, it will tell the length of my name

            //string myFaveQuote = "\"It's a yam sham\" - Buffy Summers";
            //Console.WriteLine(myFaveQuote);
            ////adding backslach with quotation marks will add quotation marks around an actual quote

            //string escapeString = "I want a tab after this line \t i want a new line without writeLine \n Hi";
            //string escapeString2 = "I want to show a backslash here \\ Hey what's that noise? \a";
            //Console.WriteLine(escapeString);
            //Console.WriteLine(escapeString2);
            ////\t=tab \n=new writeLine \\=shows only one backslash \a=makes noise

            //Console.WriteLine("User one, please type something");
            //string userOneInput = Console.ReadLine();
            //Console.WriteLine("User two, please type something");
            //string userTwoInput = Console.ReadLine();

            //if(userOneInput == userTwoInput)
            /////if(userOneInput.Equals(userTwoInput)) <------another example instead of using ==, use .Equals
            //{
            //    Console.WriteLine("User two is a copycat!");
            ////if user 2 types the same thing as user 1, then user 2 is a copycat
            //}
            //else
            //{
            //    Console.WriteLine("Way to be original!");
            /////if user 2 types something different than user 1, then he was original
            //}

            //string startOfSentence = "My best friends name is ";
            //string endOfSentence = "Zelda ";
            //Console.WriteLine(startOfSentence + endOfSentence);

            /////can also use...
            //string fullSentence = startOfSentence + endOfSentence;
            //Console.WriteLine(fullSentence);
            /////combines everything so the computer will read "My best friends name is Zelda."

            //Console.WriteLine("My friend " + endOfSentence + "is a very playful kitty.");
            //////concating the whole sentence into one CW instead of piece by piece

            //Console.WriteLine("This is a tab. \t \nThis is a backslash \\. \nAnd this is a bell sound. \a");


            // string firstName = "Paige";
            // int lengthOfFirstName = firstName.Length; ////.Length so that computer knows what it is finding
            // Console.WriteLine(lengthOfFirstName);
            // ////must make a variable for first name

            // string lastName = "Miller";
            // int lengthOfLastName = lastName.Length;
            // Console.WriteLine(lengthOfLastName);
            // ////must make a variable for last name

            // if(lengthOfFirstName > lengthOfLastName)
            //     ////is length of my first name longer than my last name
            // {
            //     Console.WriteLine("First is Longer!");
            // }
            // else if(lengthOfFirstName == lengthOfLastName)
            //     ////is the length of my first and last name the same
            // {
            //     Console.WriteLine("Samsis!");
            // }
            //else
            // {
            //     Console.WriteLine("Last must be longer!");
            //     ////all info is put in for the computer to determine if my first or last name is longer.
            // }


            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            int lengthOfFirstName = firstName.Length;

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            int lengthOfLastName = lastName.Length;

            if(lengthOfFirstName > lengthOfLastName)
            {
                Console.WriteLine("First is longer!");
            }
            else if (lengthOfFirstName == lengthOfLastName)
            {
                Console.WriteLine("Samsis!");
            }
            else
            {
                Console.WriteLine("Last must be longer!");
            }


           




            




                







        }
    }
}
