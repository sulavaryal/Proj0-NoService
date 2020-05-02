using ConsoleShopper.UI;
using System;
using System.Threading.Tasks;

namespace ConsoleShopper
{

    class Program
    {

        public static async Task Main(string[] args)
        {
           

            System.Console.Title = "Shoppoholic";

            const string title = @"
     __      __                .__                                          
/  \    /  \ ____     _____|  |__   ____ ______     ____   ______  _  __
\   \/\/   // __ \   /  ___/  |  \ /  _ \\____ \   /    \ /  _ \ \/ \/ /
 \        /\  ___/   \___ \|   Y  (  <_> )  |_> > |   |  (  <_> )     / 
  \__/\  /  \___  > /____  >___|  /\____/|   __/  |___|  /\____/ \/\_/  
       \/       \/       \/     \/       |__|          \/               
";

            CustomerCRUD customerCRUD = new CustomerCRUD();
            while (true)
            {
                System.Console.Title = "Shoppoholic";
                Console.WriteLine(title);

                System.Console.Write("\nPress 1 to get to the main menu, Press any other key to exit: ");
                var input = System.Console.ReadLine();
                if (input != "1")
                {

                    // works well on windows 10 only. 
                    System.Console.WriteLine("\u001b[31mAborting Shopping now...!\u001b[0m");
                    System.Console.Read();
                    break;
                }
                else
                {
                    System.Console.WriteLine("\n********************Welcome to the Main menu************************");

                    System.Console.WriteLine("\nPress 1 to Search for Customer,\nPress 2 to Register as a Customer, \nPress 3 to Update Customer Details, \nPress 4 to Delete the Customer");
                    System.Console.Write("\nEnter your Choice: ");

                    input = System.Console.ReadLine();

                    if (input == "1")
                    {
                        //  Search menu for Id wise or name wish search. 

                        System.Console.WriteLine("\n*****************************Welcome to the Search menu ********************************* ");
                        System.Console.WriteLine("\nPress 1 to search for Customer by Id,\nPress 2 to search Customers by Name");

                        System.Console.Write("\nEnter your Choice: ");

                        input = System.Console.ReadLine();
                        if (input == "1")
                        {
                            try
                            {

                                await customerCRUD.GetCustomerByIdAsync();
                            }
                            catch (Exception e)
                            {
                                System.Console.WriteLine(e.Message);
                            }
                        }
                        else if (input == "2")
                        {
                            try
                            {
                                await customerCRUD.GetCustomerBySearchStringAsync();
                            }
                            catch (Exception e)
                            {

                                System.Console.WriteLine(e.Message);
                            }
                        }
                        else { continue; }


                    }
                    else if (input == "2")
                    {
                        // Creates a Customer
                        try
                        {
                            int origRow = System.Console.CursorTop;
                            int origCol = System.Console.CursorLeft;
                            await customerCRUD.CreateACustomerAsync();
                            System.Console.SetCursorPosition(origCol, origRow);
                        }
                        catch (Exception e)
                        {
                            System.Console.WriteLine(e.Message);

                        }

                    }
                    else if (input == "3")
                    {
                        // Updates a Customer 
                        try
                        {
                            await customerCRUD.UpdateTheCustomerAsync();
                        }
                        catch (Exception e)
                        {
                            System.Console.WriteLine(e.Message);

                        }
                    }
                    else if (input == "4")
                    {
                        // Deletes a Customer
                        try
                        {
                            await customerCRUD.DeleteCustomerAsync();
                        }
                        catch (Exception e)
                        {

                            System.Console.WriteLine(e.Message);
                        }

                    }
                    else { break; }

                }
            }
        }
    }

}
