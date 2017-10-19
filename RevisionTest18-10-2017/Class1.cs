using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ConsoleApplication3
{
    //class remove_space
    //{
    //    public void replace(string str1)
    //    {
    //        string pattern = "\\s+";
    //        string replacement = " ";
    //        Regex rx = new Regex(pattern);
    //        string result = rx.Replace(str1, replacement);
    //        string tResult = result.Trim();

    //        int wordcount = tResult.Split(' ').Length;

    //        if (wordcount < 3)
    //        {
    //            Console.WriteLine("Please enter 3 words");
    //            Console.ReadLine();
    //        }
    //        else if (String.IsNullOrWhiteSpace(result))
    //        {
    //            Console.WriteLine("Please enter 3 words");
    //            Console.ReadLine();

    //        }
    //        else
    //        {
    //            string sSplit = result.Split(new char[' '], StringSplitOptions.RemoveEmptyEntries)[2];
    //            Console.WriteLine("Your Third word is: " + sSplit);
    //            Console.ReadLine();
    //        }
    //    }
    //    //static void Main(string[] args)
    //    {

    //        Console.WriteLine("Please enter a sentense with atleast \"3\" words");
    //        string readstr = Console.ReadLine();

    //        int wordcount = readstr.Split(' ').Length;
    //        remove_space rs = new remove_space();
    //        rs.replace(readstr);

    //    }
    //}
}
