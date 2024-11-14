using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CafeManagement
{
    class DBConnection
    {
        public string MyConnection()
        {
            string con = @"Data Source=GREY-A1N8E2J1\SQLEXPRESS;Initial Catalog=CoffeeOrderSys_Inventory;Integrated Security=True";
            return con;
        }
    }
}
