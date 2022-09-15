namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Create LinkedList\n2.To Print Add Elements In Reverse Order\n");
                Console.WriteLine("Select Your Choice: ");
                Console.WriteLine("----------------------------------\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("----------------------------------\n");
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        Console.WriteLine("----------------------------------\n");
                        break;
                    case 2:
                        Console.WriteLine("----------------------------------\n");
                        list.AddInReverseOrder(56);
                        list.AddInReverseOrder(30);
                        list.AddInReverseOrder(70);
                        list.Display();
                        Console.WriteLine("----------------------------------\n");
                        break;
                    
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}