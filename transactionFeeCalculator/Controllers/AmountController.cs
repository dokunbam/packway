using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using transactionFeeCalculator.Models;
using transactionFeeCalculator.Services;

namespace transactionFeeCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmountController : ControllerBase
    {
        // GET: api/Amount
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Amount/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        public Fee Get(decimal InputAmount)
        {
            return FeeService.GetFee(InputAmount);
        }

        // POST: api/Amount
        [HttpPost]
        public decimal Post([FromBody] decimal value)
        {
            Fee charge = Get(value);
            var amountToTransfer = value - charge.ChargedAmount;
            return amountToTransfer;
        }

        // PUT: api/Amount/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
