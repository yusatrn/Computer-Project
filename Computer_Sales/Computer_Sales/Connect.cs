using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Sales
{
    class Connect
    {
       public string adres = System.IO.File.ReadAllText(@"D:\source\repos\Computer-Project\Computer_Sales\Computer_Sales\bin\Debug\Setting.txt");
    }
}
