using System;

namespace Assignment_JP_
{
    class Program
    {
        static void Main(string[] args)
        {
            string Status, Priority, Submitter, Assigned, Watching;
            {
            Status = "Open";
            Priority = "High";
            Submitter = "Drew Kjell, Jane Doe, Drew Kjell";
            Assigned = "John Smith";
            Watching = "Bill Jones";
            }
            int id;
            
            Console.WriteLine("-----Welcome to Ticketing System-----");

           do
            {
            Console.WriteLine("Enter Your TicketID: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Need a Summary (Y/N)?");
            string option = Console.ReadLine().ToUpper();

            if (option == "Y")
                {
                Console.WriteLine("This is a bug ticket");
                
                Console.WriteLine("Enter Your Status: ");
                Status = Console.ReadLine();

                Console.WriteLine("Enter Your Priority: ");
                Priority = Console.ReadLine();

                Console.WriteLine("Enter Your Submitter: ");
                Submitter = Console.ReadLine();

                Console.WriteLine("Enter Your Assigned: ");
                Assigned = Console.ReadLine();

                Console.WriteLine("Enter Your Watching: ");
                Watching = Console.ReadLine();

                Console.WriteLine("{0} | {1} | {2} | {3} | {4}",Status,Priority,Submitter,Assigned,Watching);
                }



            else if (option == "N")
                {
                Console.WriteLine("Enter Your Status: ");
                Status = Console.ReadLine();

                Console.WriteLine("Enter Your Priority: ");
                Priority = Console.ReadLine();

                Console.WriteLine("Enter Your Submitter: ");
                Submitter = Console.ReadLine();

                Console.WriteLine("Enter Your Assigned: ");
                Assigned = Console.ReadLine();

                Console.WriteLine("Enter Your Watching: ");
                Watching = Console.ReadLine();

                Console.WriteLine("{0} | {1} | {2} | {3} | {4}",Status,Priority,Submitter,Assigned,Watching);
                }


                  
            } while (id != 1);
        }
    }
}    
