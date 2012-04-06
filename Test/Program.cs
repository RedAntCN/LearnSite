using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Model.CommomRowDataModel c = new Model.CommomRowDataModel();
            c.SetValue("FirstName", "Ouch");
             
            Console.WriteLine(c.ColumnCount);
            Console.WriteLine(c.GetValue("FirstName").ToString());
            Console.ReadKey();
            
        }
    }
}
