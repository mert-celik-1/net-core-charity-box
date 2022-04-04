using System;
using System.Collections.Generic;
using System.Text;

namespace CharityBox.Core
{
    public class Transaction
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string DestinationName { get; set; }
        public User User { get; set; }
        public string UserId { get; set; }
    }
}
