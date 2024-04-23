using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Bank_Information.Data_Access_Layer
{
    public class Customer
    {
        public int AccountNo;
        public string CustomerName;
        public string Address;
        public Customer()
        {

        }
        public Customer(int accountno, string customername, string address)
        {
            AccountNo = accountno;
            CustomerName = customername;
            Address = address;
        }
    }
}
