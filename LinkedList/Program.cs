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
                Console.WriteLine("1.Create LinkedList\n2.To Print Add Elements In Reverse Order\n3.Append Element In Linked List\n4.Insert Element At Particular Position\n5.Insert Element At First Position\n6.Delete First Element In Linked List\n7.Delete Last Element In Linked List\n8.To Search Element In Linked List\n9.Size Of Linked List\n");
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
                    case 3:
                        Console.WriteLine("----------------------------------\n");
                        list.Append(56);
                        list.Append(30);
                        list.Append(70);
                        list.Display();
                        Console.WriteLine("----------------------------------\n");
                        break;
                    case 4:
                        Console.WriteLine("----------------------------------\n");
                        list.Add(56);
                        list.Add(70);
                        list.InsertAtParticularPosition(1, 30);
                        list.Display();
                        Console.WriteLine("----------------------------------\n");
                        break;
                    case 5:
                        Console.WriteLine("----------------------------------\n");
                        list.Add(56);
                        list.Add(70);
                        list.InsertAtParticularPosition(0, 30);
                        list.Display();
                        Console.WriteLine("----------------------------------\n");
                        break ;
                    case 6:
                        Console.WriteLine("----------------------------------\n");
                        list.Pop();
                        list.Display();
                        Console.WriteLine("----------------------------------\n");
                        break;
                    case 7:
                        Console.WriteLine("----------------------------------\n");
                        list.PopLast();
                        list.Display();
                        Console.WriteLine("----------------------------------\n");
                        break;
                    case 8:
                        Console.WriteLine("----------------------------------\n");
                        list.Search(30);
                        list.Display();
                        Console.WriteLine("----------------------------------\n");
                        break;
                    case 9:
                        Console.WriteLine("----------------------------------\n");
                        list.Size();
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