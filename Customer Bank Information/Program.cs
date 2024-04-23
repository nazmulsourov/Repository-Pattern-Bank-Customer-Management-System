using Customer_Bank_Information.Business_Layer;
using Customer_Bank_Information.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Bank_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CustomerBusiness customerBusiness = new CustomerBusiness(new CustomerAssortment());
            bool isRunning = true;
            while (isRunning)
            {
                try
                {
                    Console.WriteLine("Type 'L' for List, 'A' for Add, 'U' for Update 'D' for Delete, 'S' for Search,'C' for Clear, 'X' for Exit");
                    string command = Console.ReadLine();
                    if (command == "L")
                    {
                        List<Customer> listCustomer = customerBusiness.Get();
                        Console.WriteLine("List of Customer:");
                        Console.WriteLine("AccountNo   |   CustomerName    |   Address");
                        foreach (Customer customer in listCustomer)
                        {
                            Console.WriteLine(customer.AccountNo + "  |   " + customer.CustomerName + "  |   " + customer.Address);
                        }
                    }
                    else if (command == "S")
                    {
                        Console.WriteLine("Input a AccountNo to find a customer:");
                        string AccountNo = Console.ReadLine();
                        Customer aCstomer = customerBusiness.Get(Convert.ToInt32(AccountNo));
                        Console.WriteLine(aCstomer.AccountNo + ". " + aCstomer.CustomerName + " -- " + aCstomer.Address);
                    }
                    else if (command == "A")
                    {
                        Console.WriteLine("Input a accountno:");
                        string accountno = Console.ReadLine();
                        Console.WriteLine("Input a customername:");
                        string customername = Console.ReadLine();
                        Console.WriteLine("Input a address:");
                        string address = Console.ReadLine();
                        Customer aCustomer = new Customer();
                        aCustomer.AccountNo = Convert.ToInt32(accountno);
                        aCustomer.CustomerName = customername;
                        aCustomer.Address = address;
                        bool isExecuted = customerBusiness.Add(aCustomer);
                        if (isExecuted)
                        {
                            Console.WriteLine("Added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to add.");
                        }
                    }
                    else if (command == "U")
                    {
                        Console.WriteLine("Input a id:");
                        string accountno = Console.ReadLine();
                        Console.WriteLine("Input a name:");
                        string customername = Console.ReadLine();
                        Console.WriteLine("Input a address:");
                        string address = Console.ReadLine();
                        Customer aCustomer = new Customer();
                        aCustomer.AccountNo = Convert.ToInt32(accountno);
                        aCustomer.CustomerName = customername;
                        aCustomer.Address = address;
                        bool isExecuted = customerBusiness.Update(aCustomer);
                        if (isExecuted)
                        {
                            Console.WriteLine("Updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to update.");
                        }
                    }
                    else if (command == "D")
                    {
                        Console.WriteLine("Input a accountno:");
                        string AccountNo = Console.ReadLine();
                        bool isExecuted = customerBusiness.Delete(Convert.ToInt32(AccountNo));
                        if (isExecuted)
                        {
                            Console.WriteLine("Deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to delete.");
                        }
                    }
                    else if (command == "C")
                    {
                        Console.Clear();
                    }
                    else if (command == "X")
                    {
                        isRunning = false;
                    }
                    else
                    {
                        Console.WriteLine("Command not found.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
