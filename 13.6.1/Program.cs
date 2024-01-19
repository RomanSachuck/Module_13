using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Linq;

namespace _13._6._1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> list = new List<char>();
            LinkedList<char> linkedList = new LinkedList<char>();
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();
            using (StreamReader sr = File.OpenText(@"C:\Users\Роман\Desktop\text.txt"))
            {
                while (sr.Peek() != -1)
                    list.Add((char)sr.Read());
            }
            stopWatch.Stop();
            Console.WriteLine("RunTime list.Add " + stopWatch.Elapsed);

            stopWatch.Restart();
            using (StreamReader sr = File.OpenText(@"C:\Users\Роман\Desktop\text.txt"))
            {
                while (sr.Peek() != -1)
                    linkedList.AddLast((char)sr.Read());
            }
            stopWatch.Stop();
            Console.WriteLine("RunTime Linkedlist.AddLast " + stopWatch.Elapsed);

            list.Clear();
            stopWatch.Restart();
            using (StreamReader sr = File.OpenText(@"C:\Users\Роман\Desktop\text.txt"))
            {
                while (sr.Peek() != -1)
                    list.Insert(list.Count / 2, (char)sr.Read());
            }
            stopWatch.Stop();
            Console.WriteLine("RunTime List.Insert " + stopWatch.Elapsed);
        }
    }
}
