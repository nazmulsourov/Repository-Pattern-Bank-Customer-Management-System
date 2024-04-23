using Customer_Bank_Information.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Bank_Information.Business_Layer
{
    public class CustomerBusiness
    {
        ICustomer Assortment;
        public CustomerBusiness(ICustomer assortment)
        {
            Assortment = assortment;
        }
        public List<Customer> Get()
        {
            return Assortment.Get();
        }
        public Customer Get(int id)
        {
            return Assortment.Get(id);
        }
        public bool Add(Customer model)
        {
            return Assortment.Add(model);
        }
        public bool Update(Customer model)
        {
            return Assortment.Update(model);
        }
        public bool Delete(int id)
        {
            return Assortment.Delete(id);
        }
    }
}
