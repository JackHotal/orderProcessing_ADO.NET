using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using opdblib_ado;


namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Order o = new Order("ism6236", "ism6236bo");

            Console.WriteLine(o.getCustomer("1"));
            List<String> oids = o.getCustomerOrders("1");
            foreach (String oid in oids)
            {

                List<String> ods = o.getOrderDetails(oid);
                foreach (String od in ods)
                    Console.WriteLine(od);
            }
            Console.ReadKey();
        }
    }
}
