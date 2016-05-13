using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace SearchText
{
    class Program
    {
        //Check Prime numbers using stack
        static void Main(string[] args)
        {
            string path = "D:\\1 семестр\\Fundamentals"; //The root directory to check
            Search(path); //Function that will be used(described bellow)
        }
        static void Search(String path)
        {
            Stack<string> dirs = new Stack<string>(20);
            dirs.Push(path); //Put the directory into the stack
            while (dirs.Count > 0) //Until there are items in the stack do:
            {
                DirectoryInfo dir = new DirectoryInfo(dirs.Pop()); //
                int cnt = dir.GetFiles().Length; //Count how many files in the directory
                Console.WriteLine(cnt + " files are located in " + dir.FullName); //show the number of the files 
                int cn = 0; //counter of the subdirectories
                foreach (DirectoryInfo ndir in dir.GetDirectories()) //ndir is Subdirectory
                {
                    cn++; //counter is increased
                    Console.WriteLine(cn + "." + ndir.Name); //Names of the subdirectories
                    dirs.Push(ndir.FullName); //put the subdirectory in the stack
                }

                Console.ReadKey(); //Next information will be given only after you press the button
            }
        }
    }
} 