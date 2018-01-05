using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Rich\Downloads\SampleText.txt";
            string textFromFile = System.IO.File.ReadAllText(path);
            textFromFile = textFromFile.ToLower();

            Console.WriteLine("\n What Three Letter Sequence Would You Like To Search For?  ");
            string userResponse = Console.ReadLine();

            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (var i = 0; i < 174126; i = i + 1)
            {
                if (textFromFile[i] == 't' && textFromFile[i + 1] == 'r' && textFromFile[i + 2] == 'a')
                {
                    updateDictionary(dict, "tra");
                }
            }
            Console.WriteLine($"\n {dict["tra"]}");
            Console.ReadLine();

        }
        public static void updateDictionary(Dictionary<string, int> dict, string keyCode)
        {
            if (dict.ContainsKey(keyCode))
            {
                int value = dict[keyCode];
                dict[keyCode] = ++value;
            }
            else
            {
                dict.Add(keyCode, 1);
            }
        }
    }
}