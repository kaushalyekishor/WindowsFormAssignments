using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CsharpCodeSample
{
    class FileIoExample2
    {
        public FileIoExample2()
        {
            // File.Create(@"D:\Kishor Workspace\Sample.txt");
            //  Console.WriteLine("File Created");
            // File.Copy(@"D:\Kishor Workspace\Sample.txt", @"D:\Kishor Workspace\Data\Sample.txt"); 
            // File.Move(@"D:\Kishor Workspace\Sample.txt", @"D:\Kishor Workspace\Data\Sample.txt");
            // File.Copy(@"D:\Kishor Workspace\Data\Sample.txt", @"D:\Kishor Workspace\Sample.txt");
            // File.Delete(@"D:\Kishor Workspace\Data\Sample.txt");

            FileInfo file = new FileInfo(@"D:\Kishor Workspace\Sample.txt");
            //file.Create();
            //StreamWriter writer = file.CreateText();
            //Console.WriteLine("Enter the Tect whatever you want: ");
            //writer.WriteLine(Console.ReadLine());
            //writer.Close();

            if (file.Exists)
            {
                StreamReader reader = file.OpenText();
                string str = "";
                while( (str = reader.ReadLine()) != null)
                {
                    //textBox1.Text += str;
                    Console.WriteLine(str);
                }
                
            }
        }
    }
}
