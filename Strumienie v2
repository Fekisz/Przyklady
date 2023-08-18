using System.ComponentModel;
using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

class Task
{
    public string tytul;
    public string opis;
    public DateTime data_utworzenia ;

    public Task(string tytul, string opis,DateTime dataUtworzenia=default)
    {
        if (dataUtworzenia == default)
        {
            dataUtworzenia = DateTime.Now;
        }

        this.tytul = tytul;
        this.opis = opis;
        data_utworzenia = dataUtworzenia;

    }
    public override string ToString()
    {
        return $"{tytul} - {opis} - created in {data_utworzenia}";
    }
}

static class TaskManager
{
    private static string path = "save.txt";
    static List<Task> lista = new List<Task>();
    public static void dodawaie(string name, string opis)
    {
        lista.Clear();
        lista.Add(new Task(name,opis));
        using (StreamWriter zapis = new StreamWriter(path,true))
        {
            foreach (var tasks in lista)
            {
                zapis.WriteLine(tasks.tytul);
                zapis.WriteLine(tasks.opis);
                zapis.WriteLine(tasks.data_utworzenia);
            }
        }
        lista.Clear();
    }
    

    public static void usuwanie()
    {
        Console.WriteLine("Witch task you need to remove(numbers):");
        int task_to_remove=Convert.ToInt16(Console.ReadLine());
        lista.RemoveAt(task_to_remove - 1);
        using (StreamWriter zapis = new StreamWriter(path,false))
        {
            foreach (var tasks in lista)
            {
                zapis.WriteLine(tasks.tytul);
                zapis.WriteLine(tasks.opis);
                zapis.WriteLine(tasks.data_utworzenia);
            }
        }
    }

    public static void wyswietlanie()
    {
        lista.Clear();
        List<string> xx = new List<string>();
        xx.AddRange(File.ReadAllLines(path));
        for (int i = 0; i < xx.Count; i += 3)
        {
            string name = xx[i];
            string opis = xx[i+1];
            DateTime data = Convert.ToDateTime(xx[i+2]);
            lista.Add(new Task(name,opis,data));
            
        }
        
        foreach (var linia in lista)
        {
            Console.WriteLine(linia.ToString());
        }
        xx.Clear();
        
    }
}

static class Program
{
    public static void start()
    {
        Start:
        Console.WriteLine("Chose option:");
        Console.WriteLine("1-Read task");
        Console.WriteLine("2-Write task");
        Console.WriteLine("3-Delete task");
        Console.WriteLine("4-exit");
        string chose = Console.ReadLine();
        switch (chose)
        {
            case "1":
                Console.Clear();
                TaskManager.wyswietlanie();
                goto Start;
            case "2":
                Console.Clear();
                Console.WriteLine("Write the title:");
                string title = Console.ReadLine();
                Console.WriteLine("Write task:");
                string task  = Console.ReadLine();
                TaskManager.dodawaie(title,task);
                goto Start;
            case "3":
                Console.Clear();
                TaskManager.wyswietlanie();
                TaskManager.usuwanie();
                goto Start;
            case "4":
                break;
            default:
                goto Start;
                
        }
    }
}
namespace todo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            global::Program.start();
        }
    }
}


