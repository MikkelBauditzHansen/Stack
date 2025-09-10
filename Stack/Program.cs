namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> items = new MyStack<int>();
            items.Push(1);
            items.Push(2);
            items.Push(3);
            items.Push(4);

            Console.WriteLine($"Top: {items.Peek()}");
            Console.WriteLine($"Antal: {items.Count}");
            Console.WriteLine();

            Console.WriteLine($"Pop: {items.Pop()}");
            Console.WriteLine($"Antal: {items.Count}");
            Console.WriteLine();

            Console.WriteLine($"Top: {items.Peek()}");
            Console.WriteLine($"Antal: {items.Count}");
            Console.WriteLine();

        }
    }
}
