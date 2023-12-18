namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Windows\Temp\file1.txt";
            StreamReader sr = null;


            try
            {
                
                sr = File.OpenText(sourcePath);
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null)
                    sr.Close();
            }
        }
    }
}