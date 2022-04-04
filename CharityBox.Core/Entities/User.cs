using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharityBox.Core
{
    public class User:IdentityUser<string>
    {
        public string City { get; set; }
        public bool IsAdmin { get; set; } = false;
        public decimal Balance { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Campaign> Campaigns { get; set; }
        public ICollection<Transaction> Transactions { get; set; }

    }
}
