using System;
using System.Collections.Generic;
using System.Text;

namespace CharityBox.Core
{
    public class Category
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<Campaign> Campaigns { get; set; }

    }
}
