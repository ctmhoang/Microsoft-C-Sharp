using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SC_Mod_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var openWith = new Hashtable
            {
                {"txt", "notepad.exe"}, {"bmp", "paint.exe"}, {"dib", "paint.exe"}, {"rtf", "wordpad.exe"}
            };

            try
            {
                openWith.Add("txt", "winword.exe");
            }
            catch
            {
                Console.WriteLine("An element with Key = \"txt\" already exists.");
            }
            Console.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]);

            openWith["rtf"] = "winword.exe";
            Console.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]);

            openWith["doc"] = "winword.exe"; // Add value without using add method

            if (!openWith.ContainsKey("ht"))
            {
                openWith.Add("ht", "hypertrm.exe");
                Console.WriteLine("Value added for key = \"ht\": {0}", openWith["ht"]);
            }

            Console.WriteLine();
            foreach (DictionaryEntry de in openWith)
            {
                Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
            }

        }
    }
}