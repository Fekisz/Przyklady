using System.Text;
using Microsoft.VisualBasic.FileIO;

namespace p6
{
    public static class cla
    {
        public static string path = "File.txt";

        public static void opener()
        {
            List<string> xx = new List<string>();
            xx.AddRange(File.ReadAllLines(path, Encoding.UTF8));
            int i = 1;
            foreach (string line in xx)
            {
                Console.WriteLine($"{i}. {line}");
                i++;
            }
        }

        public static void Write()
        {
            Console.WriteLine("What's the name of this movie/series");
            string user = Console.ReadLine();
            File.AppendAllText(cla.path, user);
            Console.WriteLine("your opinion ?/10");
            user = Console.ReadLine();
            File.AppendAllText(cla.path, $" {user}/10");
            File.AppendAllText(cla.path, "\n");
        }

        public static void remove()
        {
            List<string> xx = new List<string>();
            xx.AddRange(File.ReadAllLines(path, Encoding.UTF8));

            Console.WriteLine("Choose the line to remove");
            int chose = Convert.ToInt16(Console.ReadLine());
            int j = 1;

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach (string line in xx)
                {
                    if (chose != j)
                    {
                        writer.WriteLine(line);
                    }

                    j++;
                }
            }
        }

        public static void update()
        {
            List<string> xx = new List<string>();
            xx.AddRange(File.ReadAllLines(path, Encoding.UTF8));
            Console.WriteLine("Choose the line to update");
            int chose = Convert.ToInt16(Console.ReadLine());
            int j = 1;
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach (string line in xx)
                {
                    if (chose != j)
                    {
                        writer.WriteLine(line);
                    }
                    else
                    {
                        Console.WriteLine("Name of this movie/series?");
                        string user = Console.ReadLine();
                        writer.Write(user);
                        Console.WriteLine("your opinion ?/10");
                        user = Console.ReadLine();
                        writer.Write($" {user}/10");
                        writer.Write("\n");
                    }

                    j++;
                }
            }
        }

        public static void search()
        {
            List<string> xx = new List<string>();
            xx.AddRange(File.ReadAllLines(path, Encoding.UTF8));
            Console.WriteLine("Type the name:");
            string searchName = Console.ReadLine();

            int index = xx.FindIndex(linia => linia.Contains(searchName));
            // Powyższa linia używa metody FindIndex na liście xx i przekazuje do niej warunek wyszukiwania w postaci wyrażenia lambda.
            // W tym przypadku szukamy indeksu pierwszego elementu w liście, który zawiera szukany tekst.

            if (index != -1) // Jeśli znaleziono dopasowanie, to index będzie różny od -1.
            {
                Console.WriteLine($"Found at line {index + 1}: {xx[index]}");
                // Wyświetlamy informację o znalezionym dopasowaniu wraz z numerem linii (indeksem) i zawartością linii.
            }
            else
            {
                Console.WriteLine("Not found.");
                // Jeśli nie znaleziono dopasowania, wyświetlamy odpowiedni komunikat.
            }
        }

        
    }
}
