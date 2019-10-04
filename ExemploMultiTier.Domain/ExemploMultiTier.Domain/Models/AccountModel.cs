using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMultiTier.Domain.Models
{
    public class AccountModel : BaseModel
    {
        public string AccountNumber { get; set; }
        public string AgencyNumber { get; set; }
        public int BankNumber { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }

        public ICollection<ActivityModel> Activities { get; set; }
    }
}
