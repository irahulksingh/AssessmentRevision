using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {

Maximize();
            ConsoleColor1();
            bool Choices = true;

            while (Choices)
            {
                Choices = MainMenu();
            }
            
        }
        public static bool MainMenu()
        {
            Console.Clear();
            Console.CursorLeft = Console.BufferWidth - 150;
            Console.WriteLine("Hi !! May i have your Name Please ! ");
            Console.CursorLeft = Console.BufferWidth - 150;
            String sName = Console.ReadLine();
            //if (String.IsNullOrEmpty(sName))
            //{
            //    sName = "Anonmous";
            //}
            //else
            //{
                // Giving choice option to User
                Console.CursorLeft = Console.BufferWidth - 150;
                Console.WriteLine("Hey" + " " + sName + "  Choose from the following options.what would you like to do today ?\n");
                Console.CursorLeft = Console.BufferWidth - 150;
                //Console.Write("[ok]"); !!!!
                Console.WriteLine("1. Know the price of a Movie Tickets");
                Console.CursorLeft = Console.BufferWidth - 150;
                Console.WriteLine("2. Pay for group booking of Movie Tickets");
                Console.CursorLeft = Console.BufferWidth - 150;
                Console.WriteLine("3. Play the \"Ten Times\" Game");
                Console.CursorLeft = Console.BufferWidth - 150;
                Console.WriteLine("4. Play the \"Third Word\" Game");
                Console.CursorLeft = Console.BufferWidth - 150;
                Console.WriteLine("0. Exit\n ");

            // Depending on user choice calling the related method 
            Console.CursorLeft = Console.BufferWidth - 150;
            string result = Console.ReadLine();
                if (result == "1")

                {
                    iMovieTickets();
                    return true;
                }
                else if (result == "2")
                {
                    sGroupBooking();
                    return true;
                }
                else if (result == "3")
                {
                    iTenTimes();
                    return true;
                }
                else if (result == "4")
                {
                    iThirdword();
                    return true;
                }
                else if (result == "0")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            //}
        }

        private static void iMovieTickets()
        {
            Console.Clear();
            Console.CursorLeft = Console.BufferWidth - 150;
            Console.WriteLine("Hi Friend,whats your Age ?");
            //Taking user input for age.
            Console.CursorLeft = Console.BufferWidth - 150;
            string intMyAge = Console.ReadLine();
            int myAge;

            // Checking if the input is number or string
            if (!int.TryParse(intMyAge, out myAge))
            {
                Console.CursorLeft = Console.BufferWidth - 150;
                Console.WriteLine("Sorry that is not an AGE. Please try again");
                Console.ReadLine();
            }

            //if input is corrct checking which age group it belongs to and showing the Price.
            else if (myAge > 3 && myAge <= 20)
            {
                Console.CursorLeft = Console.BufferWidth - 150;
                Console.WriteLine("hey, You get a : Kids Deal : 80kr, ENJOY!!!");
                Console.ReadLine();
            }
            else if (myAge >= 21 && myAge <= 64)
            {
                Console.CursorLeft = Console.BufferWidth - 150;
                Console.WriteLine("hey, Have a wonderful movie experince : Standard Price : 120kr, ENJOY!!! ");
                Console.ReadLine();
            }

            else if (myAge > 64 && myAge < 100)
            {
                Console.CursorLeft = Console.BufferWidth - 150;
                Console.WriteLine("hey, We appreciate you : Senior citizen discount : 90kr, ENJOY!!!");
                Console.ReadLine();
            }
            else
            {
                Console.CursorLeft = Console.BufferWidth - 150;
                Console.WriteLine("Congratulations !!! You get a free ticket for the movie");
            }
            Console.CursorLeft = Console.BufferWidth - 150;
            Console.ReadLine();
        }

        private static void iTenTimes()
        {
            Console.Clear();
            //Caputuring user input
            Console.CursorLeft = Console.BufferWidth - 150;
            Console.WriteLine("Please insert a string :-");
            Console.CursorLeft = Console.BufferWidth - 150;
            string iUser = Console.ReadLine();

            //Assigning value of time we need the repeatition
            int intUser = 10;
            for (int i = 0; i < intUser; ++i)

            {
                //printing the value of User input text number of times 
                int iValue = i + 1;
                //Console.CursorLeft = Console.BufferWidth - 150;
                Console.Write(iValue + "." + iUser + ",");
            }
            Console.CursorLeft = Console.BufferWidth - 150;
            Console.ReadLine();
        }

         private static void iThirdword()
        {
            Console.Clear();
            // Taking user input and saving it to a string.
            Console.WriteLine("Please enter a sentense with atleast \"3\" words");
            string sSentense = Console.ReadLine();
            int wordcount = sSentense.Split(' ').Length;
            // Checking if user input is more then 3 words or not, if it is smaller then showing an error.
            if (String.IsNullOrWhiteSpace(sSentense) || wordcount < 3)
            {
             
                Console.WriteLine("Please enter 3 or more words");
                Console.ReadLine();
           }
            //After checking if user input is more then 3 words 
            else if (wordcount>2)
            {
                // We are replacing the whitespaces in the sentense with a single whitespace.
                string ssSplit;
                ssSplit = Regex.Replace(sSentense, @"\s+", " ");
                string sSplit = ssSplit.Split(' ')[2];
               
                if(String.IsNullOrWhiteSpace(sSplit))
                {
                    Console.WriteLine("Please enter 3 or more words");
                }
                 else
                { 
                //Writting the output to thr console.
                Console.WriteLine("Your Third word is" + "  " + sSplit);
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your entry is not valid, Please enter more 3 or more words");
               Console.ReadLine();
            }
        }

        private static void sGroupBooking()
        {
            Console.Clear();
            // Taking user input assigning to a string.
            Console.CursorLeft = Console.BufferWidth - 150;
            Console.WriteLine("How many people are you to watch this movie");
            Console.CursorLeft = Console.BufferWidth - 150;
            string sPeople = Console.ReadLine();

            //Declaring variables.
            int iNum;
            int iTotal = 0;
            string sInput;
            int iAge;

            // checking of the input is a number or string.

            if (int.TryParse(sPeople, out iNum))
            {
                for (int i = 0; i < iNum; i++)
                {
                    //Taking user input for age of people.
                    Console.CursorLeft = Console.BufferWidth - 150;
                    Console.Write("Please input the age of person " + (i + 1).ToString() + ":");
                    
                    sInput = Console.ReadLine();
                    if (!int.TryParse(sInput, out iAge))
                    {
                        // if the age provided is not a number show this error.
                        Console.CursorLeft = Console.BufferWidth - 150;
                        Console.WriteLine("Invalid age, please try again");
                        i--;
                    }
                    else
                        // if the age is correct from method Price check the age group and proce and add to the total.
                        Console.CursorLeft = Console.BufferWidth - 150;
                    iTotal += Price(iAge);
                }
                // printing the total cost.
                Console.CursorLeft = Console.BufferWidth - 150;
                Console.WriteLine("The Total Cost for Tickets in {0:C}", iTotal);
            }
            else
            Console.WriteLine("Incorrect number of persons");
            Console.CursorLeft = Console.BufferWidth - 150;
            Console.ReadLine();

        }

        private static int Price(int iAge)
        {
            //Checking the price depending on the age group.
            int iPrice = 0;
            if (iAge <= 3 || iAge > 100)
            {
                iPrice = 0;
            }
            else if (iAge < 20)
            {
                iPrice = 80;
            }
            else if (iAge > 64)
            {
                iPrice = 90;
            }
            else
            {
                iPrice = 120;
            }
            return iPrice;
        }
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(System.IntPtr hWnd, int cmdShow);

        private static void Maximize()
        {
            Process p = Process.GetCurrentProcess();
            ShowWindow(p.MainWindowHandle, 3); //SW_MAXIMIZE = 3
        }
        public static void ConsoleColor1()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;

        }

    }
    
}


