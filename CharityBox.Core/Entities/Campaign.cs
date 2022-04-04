using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharityBox.Core
{
    public class Campaign
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public decimal Limit { get; set; }
        public decimal CurrentMoney { get; set; }
        public bool IsDone { get; set; } = false;
        public bool IsVerified { get; set; } = true;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string City { get; set; }
        public bool IsRejected { get; set; } = false;
        [JsonIgnore]
        public Category Category { get; set; }
        public string CategoryId { get; set; }
        [JsonIgnore]
        public User User { get; set; }
        public string UserId { get; set; }
    }
}
