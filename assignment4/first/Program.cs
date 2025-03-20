using System.ComponentModel.DataAnnotations;

namespace _2025_3_13_assignment4
{
    public class Node<T>
    {
    public Node<T> Next { get; set; }
    public T Data { get; set; }
    public Node( T data)
        {
            Next = null;
            Data = data;
        }
    }

    public  class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public GenericList()
        {
            tail = head = null;
        }
        public Node<T> Head { get => head; }
        public void add(T t)
        {
            Node<T> n=new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void Foreach(Action<T> action)
        {   Node<T>current = head;
            while(current!=null) {
                action(current.Data);
                current = current.Next;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            list.add(1);
            list.add(2);    
            list.add(3);
            list.add(4);

            Console.WriteLine("遍历链表求所有元素：");
            list.Foreach(x => Console.Write(x+" "));
            Console.WriteLine();
            Console.WriteLine("最大元素：");
            int max = int.MinValue;
            list.Foreach(x => max = Math.Max(max, x));
            Console.WriteLine(max);
            Console.WriteLine("最小元素：");
            int min = int.MaxValue;
            list.Foreach(x => min = Math.Min(min, x));
            Console.WriteLine(min);
            Console.WriteLine("求和：");
            int all = 0;
            list.Foreach(x => all += x);
            Console.WriteLine(all);
        }
    }
}