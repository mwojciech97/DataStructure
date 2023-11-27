using LinkedLists;
using System.Diagnostics;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OneWayList<int> a = new OneWayList<int>();
            a.AddLast(5);
            a.AddLast(6);
            a.AddLast(7);
            a.DeleteLast();
            a.Print();
        }
    }
}