using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using transactionFeeCalculator.Models;

namespace transactionFeeCalculator.Services
{
    public class FeeService
    {
        public FeeService()
        {

        }


        public static Fee GetFee(decimal amount)
        {
            // please fill in the roght amount
            if (amount > 1 && amount < 5001)
                return new Fee
                {
                    ChargedAmount = 10
                };
            else if (amount > 5001 && amount < 50001)
                return new Fee
                {
                    ChargedAmount = 25
                };
            else //if (amount > 50001 && amount < 999999999)
                return new Fee
                {
                    ChargedAmount = 50
                };
            //Please you can continue
        }
    }
}
