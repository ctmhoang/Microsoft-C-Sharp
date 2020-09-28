using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Mod3_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = null;
            try
            {
                reader = new StreamReader("file1.txt");

                string content = reader.ReadToEnd();

                reader.Close();

                Console.WriteLine("The file has {0} text elements", new StringInfo(content).LengthInTextElements);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("The file cannot be found.");
                throw;
            }
            finally
            {
                reader?.Dispose();
            }

            using ( reader = File.OpenText("file1.txt"))
            {
                Console.WriteLine("The file has {0} text elements", new StringInfo(reader.ReadToEnd()).LengthInTextElements);
            }
        }
    }
}
