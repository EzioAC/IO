using System;
using System.IO;

namespace IO
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new byte[1024];
            var file = new FileStream("test1.txt", FileMode.Open);
            while (file.Read(array, 0, 1024) > 0)
            {
                foreach(var i in array)
                    Console.Write(i);
            }
            file.Close();
        }
    }
}
