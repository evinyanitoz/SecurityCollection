using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Customer> list = new List<Customer>();
            list.Add(new Customer() { Id = 1, FirtsName = "EVİN" });
            list.Add(new Customer() { Id = 2, FirtsName = "YAĞMUR" });
            list.Add(new Customer() { Id = 3, FirtsName = "ŞAHSENEM" });
            foreach (var item in list)
            {
                Console.WriteLine(item.FirtsName);
            }
            Console.WriteLine("*************************************");

            //DİĞER KULLANIM ŞEKLİ ;
            List<Customer> list2 = new List<Customer> {
            new Customer { Id = 1, FirtsName = "MERVE" },
           new Customer { Id = 2, FirtsName = "ZÜLEYHA" },
            new Customer { Id = 3, FirtsName = "ADEM" } };
            foreach (var item in list2)
            {
                Console.WriteLine(item.FirtsName);
            }
            Console.ReadLine();

            //Collection Özellik ve metotlarıyla çalışmak,
        }
       
    }
    class Customer
    {

        public int Id { get; set; }
        public string FirtsName { get; set; }
    }
}