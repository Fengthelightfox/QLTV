using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_thu_vien
{
    public class Connection
    {
        private static string cnnString = @"Data Source=LAPTOP-IP1RMDOK;Initial Catalog=Quan_ly_thu_vien;Integrated Security=True";

        public static string CnnString
        {
            get { return cnnString; }
        }
    }
}
