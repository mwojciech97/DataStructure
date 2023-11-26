using LinkedLists;
namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OneWayList a = new OneWayList();
            a.AddLast(5);
            a.AddLast(10);
            a.AddLast(15);
            a.AddLast(20);
            a.AddLast(25);
            a.AddAfter(a.First(), 17);
            a.Print();
           /* LinkedList<int> list = new LinkedList<int>();
            list.AddLast(5);
            list.AddLast(10);
            list.AddLast(15);*/
        }
    }
}