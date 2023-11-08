using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_1.AppData
{
    public class ConDB
    {
        public static BazasuperEntities con;
        public static BazasuperEntities context
        { 
            get 
            {
                if(con == null) con = new BazasuperEntities();
                return con;
            } 
        } 
        public static bool Check(spravochniki sp)
        {
            if(string.IsNullOrEmpty(sp.aadress) || string.IsNullOrEmpty(sp.full_name)) 
                return false;
            return true;
        }

        public static bool CheckUchet(uchetnaya uchet)
        {
            if (string.IsNullOrWhiteSpace(uchet.month_of_payment) || uchet.tarif == 0 || uchet.id_litsscheta == 0 || uchet.id_zapisi == 0)
                return false;
            return true;
        }
    }
}
