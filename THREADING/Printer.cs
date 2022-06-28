namespace  Prn.Threading;
using static System.Console;
public class Printer
{
    public void PrintNumbers()
    {
        for(int i = 0; i <=5; i++)
        {
            WriteLine(i);
            Thread.Sleep(1000);
        }
    }

    public void PrintCharacter(char c)
    {
        for (int i = 1; i <= 5; i++)
        {
            WriteLine($"Print character {c} - {i}");
            Thread.Sleep(1000);
        }
    }
}