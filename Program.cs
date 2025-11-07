using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string user, pass, prodName;
            double qty, price, totalPrice, amt, dscnt, fnlprc;


            Console.Write("Enter username: ");
            user = Console.ReadLine();
            Console.Write("Enter password: ");
            pass = Console.ReadLine();

            if (user == "admin" && pass == "123")
            {
                Console.WriteLine("STORE MENU");
                Console.WriteLine("A Compute Product Total");
                Console.WriteLine("B. Compute Customer Discount");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if(choice == "A")
                {
                    Console.Write("Enter product name: ");
                    prodName = Console.ReadLine();
                    Console.Write("Enter quantity: ");
                    qty = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter price per unit: ");
                    price = Convert.ToDouble(Console.ReadLine());

                    totalPrice = qty * price;

                    Console.WriteLine("Product: " + prodName);
                    Console.WriteLine("Total Price: " + totalPrice);
                    Console.WriteLine("Quantity: " + qty);

                }else if(choice == "B")
                {
                    Console.Write("Customer Name: ");
                    prodName = Console.ReadLine();  
                    Console.Write("Purchase Amount: ");
                    amt = Convert.ToDouble(Console.ReadLine());

                    if (amt >= 10000)
                    {
                        dscnt = 0.20;
                    }else if(amt >= 5000)
                    {
                        dscnt = 0.10;
                    }
                    else if(amt >= 1000)
                    {
                        dscnt = 0.05;
                    }
                    else
                    {
                        dscnt = 0.0;
                    }

                    dscnt = amt * dscnt;
                    fnlprc = amt - dscnt;

                    Console.WriteLine("Customer Name: " + prodName);
                    Console.WriteLine("Discount: " + dscnt);
                    Console.WriteLine("Final Price: " + fnlprc);



                    



                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }






            }
            else
            {
                Console.WriteLine("Access denied.");
            }

        Console.ReadKey();
        }
    }
}
