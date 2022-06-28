namespace Prn.Threading;

public class Program
{
    public static void Main()
    {
        //1. Gia su co 1 lop Printer co 1 ham la print so tu 1-5

        Printer p = new Printer();
        //p.PrintNumbers();
        //Console.WriteLine("=====================");
        //p.PrintNumbers();
        //Console.WriteLine("======================");
        //p.PrintNumbers();


        //p.PrintCharacter('a');
        //Console.WriteLine("=====================");
        //p.PrintCharacter('b');
        //Console.WriteLine("=====================");
        //p.PrintCharacter('c');

        ////2. tao ra 3 luong to print the numbers from 1 to 5
        //    //3 luong chay song song
        //    // in ra ngau nhien
        //Thread t1 = new Thread(()=>p.PrintCharacter('a'));
        //t1.Start();
        //Thread t2 = new Thread(()=>p.PrintCharacter('b'));
        //t2.Start();
        //Thread t3 = new Thread(()=>p.PrintCharacter('c'));
        //t3.Start();

        Thread[] arrThreads = new Thread[5];
          arrThreads[0] = new Thread(()=>p.PrintCharacter('a'));
            arrThreads[1] = new Thread(()=>p.PrintCharacter('b'));
            arrThreads[2] = new Thread(()=>p.PrintCharacter('c'));
            arrThreads[3] = new Thread(()=>p.PrintCharacter('d'));
            arrThreads[4] = new Thread(()=>p.PrintCharacter('e'));
        
        for (int i = 0; i < 5; i++)
        {
            arrThreads[i].Start();
        }

        Console.ReadLine();
    }
}