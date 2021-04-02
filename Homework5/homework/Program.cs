using System;
using System.Collections.Generic;
using System.Linq;

namespace homework
{
    class Program
    {
        struct Order
        {
            public int Ono;
            public String Oname;
            public String Ocustomer;
            public double Oprice;
        }
        class OrderServer
        {
            private Order firstorder = new Order();
            
            public bool setList(List<Order> list)
            {
                list.Clear();
                list.Add(firstorder);
                return true;
            }

            public bool SelectByNo(List<Order> list, int no) 
            {
                var result = from order in list
                             where no == order.Ono
                             orderby order.Oprice descending
                             select order;

                foreach(Order order0 in result)
                {
                    Console.WriteLine("Order NO.{0} Name:{1} ", order0.Ono, order0.Oname);
                }

                return true;
            }
            public bool SelectByName(List<Order> list, String name)
            {
                var result = from order in list
                             where name == order.Oname
                             orderby order.Oprice descending
                             select order;

                foreach (Order order0 in result)
                {
                    Console.WriteLine("Order NO.{0} Name:{1} ", order0.Ono, order0.Oname);
                }

                return true;
            }
            public bool SelectByPrice(List<Order> list, int price)
            {
                var result = from order in list
                             where price == order.Oprice
                             orderby order.Oprice descending
                             select order;

                foreach (Order order0 in result)
                {
                    Console.WriteLine("Order NO.{0} Name:{1} ", order0.Ono, order0.Oname);
                }

                return true;
            }
            public bool SelectByCus(List<Order> list, String cus)
            {
                var result = from order in list
                             where cus == order.Ocustomer
                             orderby order.Oprice descending
                             select order;

                foreach (Order order0 in result)
                {
                    Console.WriteLine("Order NO.{0} Name:{1} ", order0.Ono, order0.Oname);
                }

                return true;
            }

            public void changeOrder(List<Order> list,int No)
            {

            }
        }

        static void Main(string[] args)
        {
            

        }
    }
}
