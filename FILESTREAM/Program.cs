using System.IO;
using System.Text;
namespace Prn.FileStreamDemo;

public class Program
{
    public static void Main()
    {
        //1. msg ta muon wriete vao file (FileStream)
        string msg = "ABCDEFG";
        //2. convert msg => array bytes
        byte[] bufferBytes = Encoding.Default.GetBytes(msg);
        //3. dung FileStream to write to file by path
        using FileStream fileStream = File.Open("data.dat", FileMode.Create);
        //4. excute insert data to file
        fileStream.Write(bufferBytes, 0, bufferBytes.Length);
        fileStream.Position = 0;

    }
}

