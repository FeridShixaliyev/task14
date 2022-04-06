using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp43
{
    class Shop
    {
        List<Order> orders = new List<Order>();
        public void AddOrder(Order obj)
        {
            orders.Add(obj);
        }
        public void RemoveOrderByNo(int no)
        {
           orders.Remove(orders.Find(o => o.No == no));
            
        }
        public List<Order> FilterOrderByPrice(int min,int max)
        {
            List<Order> filteredprice = new List<Order>();
            var result = orders.Find(o => o.TotalAmount > min && o.TotalAmount < max);
            filteredprice.Add(result);
            return filteredprice;           
        }
        public int GetOrdersAvg(DateTime date)
        {
            List<Order> filteredprice = new List<Order>();

            filteredprice.AddRange(orders.FindAll(o => o.CreatedAt.Date.Hour>= date.Hour));
            int sum = 0;
            foreach (var item in filteredprice)
            {
                sum += item.TotalAmount;
            }
            return sum/ filteredprice.Count;
        }
        public int GetOrdersAvg()
        {
            int sum = 0;
            foreach (var item in orders)
            {
                sum += item.TotalAmount;
            }
                sum /= orders.Count;
            return sum;
        }
    }
}
