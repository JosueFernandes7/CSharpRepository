
class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> cookies = new Dictionary<string, string>();

        cookies["user"] = "john";
        cookies["email"] = "john@email.com";
        cookies["password"] = "john1234";

        // Wrong 
        foreach (KeyValuePair<string,string> item in cookies)
        {
            Console.WriteLine(item.Key);
            Console.WriteLine(item.Value);
        }

        foreach ((string key, string value) in cookies)
        {
            Console.WriteLine(value);
            Console.WriteLine(key);
        }

    }
}