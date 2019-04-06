using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0727100_assignment4
{
    class Program

    {

        ArrayList Beowulf;



        static void Main(string[] args)

        {



            Program p = new Program();

            p.Beowulf = new ArrayList();

            p.Wordskipper();

            Console.ReadLine();



        }

        public void Run()

        {

            this.ReadTextFiles();

        }



        public void ReadTextFiles()

        {



            // Read file using StreamReader. Read file line by line

            using (StreamReader file = new StreamReader(@"C:\notepad\Beowulf.txt"))

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

            {

                foreach (char c in line)

                {

                    if (char.IsLetter(c)) { countletters++; }

                    if (char.IsWhiteSpace(c)) { countSpaces++; }

                }

                return countSpaces;

            }

        }

        public void CountLinesReader()

        {

            long lineCounter = 0;

            using (StreamReader fil = new StreamReader(@"C:\notepad\Beowulf.txt"))

            {

                while (fil.ReadLine() != null)

                {

                    lineCounter++;

                }

                Console.WriteLine(lineCounter);

            }

        }

        public void WordCounter()

        {



            StreamReader reader = new StreamReader(@"C:\notepad\Beowulf.txt");

            string script = reader.ReadToEnd();



            var text = script.Trim();

            int wordCount = 0, index = 0;



            while (index < text.Length)

            {

                // check if current char is part of a word

                while (index < text.Length && !char.IsWhiteSpace(text[index]))

                    index++;



                wordCount++;



                // skip whitespace until next word

                while (index < text.Length && char.IsWhiteSpace(text[index]))

                    index++;

            }



            Console.WriteLine(wordCount);





        }

        public void Wordfinder()

        {

            int f = 0;

            foreach (var line in File.ReadAllLines(@"C:\notepad\Beowulf.txt"))

            {

                f++;

                if (line.Contains("sea") && line.Contains("fare"))

                {

                    Console.WriteLine(f);

                }



            }

        }

        public void Wordskipper()

        {

            int f = 0;

            foreach (var line in File.ReadAllLines(@"C:\notepad\Beowulf.txt"))

            {

                f++;

                if (line.Contains("fare") && (!line.Contains("war")))

                {

                    Console.WriteLine(f);

                }



            }



        }

        public void Letters()

        {



            StreamReader reader = new StreamReader("Beowulf.txt");

            string script = reader.ReadToEnd();

            int numberOfLetters = 0;

            foreach (char letter in script)

            {

                numberOfLetters++;

            }

            Console.WriteLine(numberOfLetters);



        }



    }



}