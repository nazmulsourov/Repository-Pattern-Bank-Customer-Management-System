using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Bank_Information.Data_Access_Layer
{
    public interface ICustomer
    {
        List<Customer> Get();
        Customer Get(int accountno);
        bool Add(Customer model);
        bool Update(Customer model);
        bool Delete(int accountno);
    }
}
