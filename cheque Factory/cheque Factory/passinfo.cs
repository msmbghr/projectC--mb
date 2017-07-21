using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cheque_Factory
{
  public static class connecteiondatabase
    {
        public static string passconnection()
        {
            string mystrstr = @"Data Source=.;Initial Catalog=cheque factory;Integrated Security=True";
            return mystrstr;
        }
    }
}
