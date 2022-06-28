namespace PRN_DEFAULT_INTERFACE;


public interface Issample
{
    static void Print()
    {
        Console.WriteLine($"Welcome to .NET");
    }

    string Getstring(string s)
    {
        return "Hello " + s;
    }

    void Display();

}

public class MySample : Issample
{
    public void Display()
    {
        Console.WriteLine($" Hi ");
    }
}

public class Program
{
    public static void Main()
    {
        MySample obj = new MySample();
        obj.Display();
        Issample.Print();
        Issample s = obj;
        string str = s.Getstring("HNGB");
        Console.WriteLine(str);
        Console.ReadLine();
    }
}
