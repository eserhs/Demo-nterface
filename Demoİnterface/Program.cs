using System;

namespace Demoİnterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer ınterface = new Customer

            {
                adı = "ahmet ",
                soyadı = "güngör",
                ıd = 1



            };

            Interface1 ınterface2 = new Seller
            {
                ıd = 1,
                adı = "mehmet ",
                soyadı = "yürek",
                katagori = "giyim",
                müşterino = 133
            };
            Customer[] customers = new Customer[] {ınterface, };

            foreach (var item in customers)
            {
                Console.WriteLine(item.ıd);
                Console.WriteLine(item.adı);
                Console.WriteLine(item.soyadı);
            }



            Interface1 ınterface11 =  new Customer();
           // ınterface11.add();
          //  ınterface11.deletion();
            ınterface11.update();
          

       

           

        }
    }
}
