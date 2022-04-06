using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp43
{
    class Order
    {
        public Order()
        {
            _createdAt = DateTime.UtcNow.Date;
            CreatedAt = _createdAt;
            _no++;
            No = _no;
        }
        private static DateTime _createdAt;
        private static int _no;
        public int No { get; set; }
        public int ProductCount { get; set; }
        public int TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
