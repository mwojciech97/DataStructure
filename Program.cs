using LinkedLists;
namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OneWayList a = new OneWayList();
            a.Push(5);
            a.Push(10);
            a.Push(15);
            a.Print();
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(5);
            list.AddLast(10);
            list.AddLast(15);
        }
    }
}