//Um site de internet registra um log de acessos dos usuários. Um registro de log consiste no nome
//de usuário e o instante em que ousuário acessou o site no padrão ISO 8601, separados por espaço,
//conforme exemplo. Fazer um programa que leia o log de acessos apartir de um arquivo, e daí informe quantos usuários distintos acessaram o site.
using Exercicio.Entities;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        HashSet<LogRecord> records = new HashSet<LogRecord>();

        Console.Write("Enter file full path: ");
        //string path = Console.ReadLine();
        string path = @"C:\Users\Josué\usuarios.txt";

        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(" ");
                    LogRecord record = new LogRecord(line[0], DateTime.Parse(line[1]));
                    records.Add(record);
                }
            }

            Console.WriteLine($"Total users: {records.Count}");
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}