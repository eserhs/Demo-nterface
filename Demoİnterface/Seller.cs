using System;
using System.Collections.Generic;
using System.Text;

namespace Demoİnterface
{
    class Seller :Customer,  Interface1
    {

        public int stok { get; set; }
        public int müşterino { get; set; }
        public string katagori { get; set; }

        void Interface1.add()
        {
            Console.WriteLine("ekledi : ");
        }

        void Interface1.deletion()
        {
            Console.WriteLine("silindi :");
        }
        void Interface1.update()
        {
            Console.WriteLine("güncellendi ");
        }
    }
}
