using System;
using System.IO;

namespace CsharpCodeSample
{
    class FileIoExample
    {
        public FileIoExample()
        {
            FileStream file = new FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            for (int i = 1; i <= 20; i++)
            {
                file.WriteByte((byte)i);
            }
            file.Position = 0;
            for (int i = 0; i <= 20 ; i++)
            {
                Console.Write(file.ReadByte() + " ");
            }
            file.Close();
            Console.ReadKey();
        }
    }
}