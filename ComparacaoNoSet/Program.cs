

class Program
{
    static void Main(String[] args)
    {
        HashSet<String> set = new HashSet<String>();
        set.Add("Maria");
        set.Add("Alex");
        set.Add("Jose");

        Console.WriteLine(set.Contains("Maria"));

    }
}