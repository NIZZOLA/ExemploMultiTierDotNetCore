using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMultiTier.Domain.Models
{
    // classe dos movimentos da conta
    public class ActivityModel : BaseModel
    {
        //valor
        public decimal Amount { get; set; }
        
        // vencimento
        public DateTime DueDate { get; set; }

        // data da compra
        public DateTime PurchaseDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal? PaymentValue { get; set; }
        public string Description { get; set; }
        public int AccountId { get; set; }
        public AccountModel Account { get; set; }
    }
}
