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
            //Console.WriteLine(textFromFile);

            int counter;
            counter = 0;

            for (var i = 0; i < 174126; i = i + 1)
            {
                if (textFromFile[i] == 't' && textFromFile[i+1] == 'r' && textFromFile[i+2] == 'a')
                {
                    counter ++;
                    
                }
                
            }
            Console.WriteLine(counter);

            Console.ReadLine();

        }
    }
}