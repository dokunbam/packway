using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace transactionFeeCalculator.Models
{
    public class Fee
    {
        public float MinAmount { get; set; } = 0;
        public decimal MaxAmountFee { get; set; } = 0;
        public int ChargedAmount { get; set; } = 0;

    }
}
