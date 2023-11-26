using LinkedLists;
namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OneWayList<int> a = new OneWayList<int>();
            a.AddLast(5);
            a.AddLast(10);
            a.AddLast(15);
            a.AddLast(20);
            a.AddLast(25);
            a.AddLast(5);
            a.AddLast(11);
            a.AddLast(12);
            a.AddLast(5);
            a.Print();
            /* LinkedList<int> list = new LinkedList<int>();
             list.AddLast(5);
             list.AddLast(10);
             list.AddLast(15);*/
        }
    }
}