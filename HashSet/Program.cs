

class Program
{
    static void Main(String[] args)
    {
        HashSet<String> set = new HashSet<String>();
        set.Add("a");
        set.Add("b");
        set.Add("c");

        Console.WriteLine(set.First());
        Console.WriteLine(set.Count);

        foreach (String s in set)
        {
            Console.WriteLine(s);
        }
    }
}