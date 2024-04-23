using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Bank_Information.Data_Access_Layer
{
    public class CustomerAssortment: ICustomer
    {
        List<Customer> listCustomer = new List<Customer>()
        {
            new Customer(1,"Sourov", "Tejkunipara"),
            new Customer(2,"Arman", "Badda"),
            new Customer(3,"Sohel", "Mohakhali"),
        };
        public List<Customer> Get()
        {
            return listCustomer.OrderBy(x => x.CustomerName).ToList();
        }
        public Customer Get(int accountno)
        {
            Customer Customer = listCustomer.Where(x => x.AccountNo == accountno).FirstOrDefault();
            return Customer;
        }
        public bool Add(Customer model)
        {
            listCustomer.Add(model);
            return true;
        }
        public bool Update(Customer model)
        {
            bool isExecuted = false;
            Customer Customer = listCustomer.Where(x => x.AccountNo == model.AccountNo).FirstOrDefault();
            if (Customer != null)
            {
                listCustomer.Remove(Customer);
                listCustomer.Add(model);
                isExecuted = true;
            }
            return isExecuted;
        }
        public bool Delete(int accountno)
        {
            bool isExecuted = false;
            Customer Customer = listCustomer.Where(x => x.AccountNo == accountno).FirstOrDefault();
            if (Customer != null)
            {
                listCustomer.Remove(Customer);
                isExecuted = true;
            }
            return isExecuted;
        }
    }
}
