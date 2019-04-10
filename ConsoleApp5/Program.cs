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
        int counterletters = 0;
        int countSpaces = 0;
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
            using (StreamReader sr  = new StreamReader("U:/Users/730283/Downloads/Beowulf.txt"))
            {
                string line;
                int counter = 0;
                int a = 0, myWord = 1;

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    Beowulf.Add(line);
                    FindNumberOfBlankSpaces(line);
                    counter++;

                    while (a <= line.Length - 1)
                    {
                        if (line[a] == ' ' || line[a] == '\n' || line[a] == '\t')
                        {
                            myWord++;
                        }
                        a++;
                    }
                    a = 0;

                }


                Console.WriteLine("\n\n\n\n********************************The number of lines in the paragraph is " + counter);
                Console.WriteLine("The number of words in paragraph is " + myWord);
                Console.ReadLine();
            }

        }
        public int FindNumberOfBlankSpaces(string line)
        {


            foreach (char c in line)
            {
                if (char.IsLetter(c)) { counterletters++; }
                if (char.IsWhiteSpace(c)) { countSpaces++; }
            }
            return countSpaces;
        }
    }
}


