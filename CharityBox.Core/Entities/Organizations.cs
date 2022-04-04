using System;
using System.Collections.Generic;
using System.Text;

namespace CharityBox.Core
{
    public class Organizations
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public string PhotoUrl { get; set; }
    }
}
