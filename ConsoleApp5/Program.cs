using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        ArrayList Beowulf;
        int LineCount = 0;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.Run();
        }
        public void Run() { this.ReadTextFiles(); }
        public void ReadTextFiles()
        {
            // Read file using StreamReader.reads file line by line
            using (StreamReader file = new StreamReader("U:/Users/730283/Downloads/Beowulf.txt"))
            {
                int counter = 0;
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);

                }
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
            }
        }
        public int FindNumberOfBlankSpaces(string line)
        {
            int countletters = 0;
            int countSpaces = 0;
            foreach (char c in line)
            {
                if (char.IsLetter(c)) { countletters++; }
                if (char.IsWhiteSpace(c)) { countSpaces++; }
            }
            return countSpaces;

        }
        public void Line()
        {
            string line;
            TextReader reader = new StreamReader("U: /Users/730263/downloads/Beowulf.txt");
            while ((line = reader.ReadLine()) != null)
            {
                LineCount++;
            }
            reader.Close();
            Console.WriteLine(LineCount);
        }
    }
}

     
   
