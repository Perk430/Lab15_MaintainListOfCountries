using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class CountriesTextFiles
    {
        public static string ReadFromFile()
        {
            StreamReader rd = new StreamReader("../../Countries.txt");
            string FileContent = rd.ReadToEnd();

            Console.WriteLine(FileContent);
            rd.Close();

            return FileContent;
        }

        public static void WriteToFile(string input)
        {
            StreamWriter sw = new StreamWriter("../../Countries.txt", true);

            sw.WriteLine(input);

            sw.Close();
        }
    }
}
