using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = @"C:\Users\Josué\Desktop\CSharpRepository\ArquivosExercicio\table.csv";

        try
        {
            using (StreamReader reader = new StreamReader(path))
            {
                // Lê o cabeçalho
                string header = reader.ReadLine();
                string[] headers = header.Split('\t');
                PrintRow(headers);

                // Lê e imprime cada linha de dados
                while (!reader.EndOfStream)
                {
                    //string line = reader.ReadLine();
                    //string[] values = line.Split('\t');
                    Console.WriteLine(reader.ReadLine());
                    //PrintRow(values);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao ler o arquivo CSV: {ex.Message}");
        }
    }

    // Função auxiliar para imprimir uma linha de dados
    static void PrintRow(string[] lines)
    {
        string[] e = line.Split(";");
        Console.WriteLine($"Nome: {e[0]}, Preco: {e[1]}");
    }
}
