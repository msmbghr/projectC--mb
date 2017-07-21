using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cheque_Factory
{
    class connectiondb
    {
   //     static string s = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "cheque Factory.mdb";
        static string s = @"(LocalDB)\v11.0;AttachDbFilename=G:\MY Programing\cheque print\cheque Factory\cheque factory.mdf;Integrated Security=True;Connect Timeout=30";
        static public string myconn
        {

            get
            {
                return s;
            }
        }
    }
}
