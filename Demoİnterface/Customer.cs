using System;
using System.Collections.Generic;
using System.Text;

namespace Demoİnterface
{
    class Customer : Interface1
        



    {
        public int ıd { get; set; }
          private string _adı;
                public  string adı
        {
            
            get
            {
                return "sayı  : " + _adı;
              


            }
            set
            {
                _adı = value;
            }
                }
        public string soyadı { get; set; }
        


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
