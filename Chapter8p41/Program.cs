using System;
using System.IO;
namespace Chapter8p41
{
    
    internal class Program
    {
        const string FileName = @"C:\2\BinaryFile.bin";
        static void WriteFile(string fileName)
        {
            if (File.Exists(FileName))
            {
                using (BinaryWriter bw = new BinaryWriter(File.OpenWrite(FileName)))
                {
                    bw.Write($"файл изменен:{DateTime.Now} на ОС {Environment.OSVersion}" );
                }
            }
        }
        static void ReadFile()
        {
            if (File.Exists(FileName))
            {
                string date;
                string str;
                using(BinaryReader br = new BinaryReader(File.OpenRead(FileName)))
                {
                    date = br.ReadString();
                //    str = br.ReadString();
                }
                Console.WriteLine(date);
               // Console.WriteLine(str);
            }

        }
        static void Main(string[] args)
        {
            WriteFile(FileName);
            ReadFile();
            Console.WriteLine("Hello, World!");
        }
    }
}