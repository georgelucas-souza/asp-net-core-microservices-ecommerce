using ECommerce.Apis.Customers.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Apis.Customers.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerProvider customerProvider;

        public CustomerController(ICustomerProvider customerProvider)
        {
            this.customerProvider = customerProvider;
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomersAsync()
        {
            var result = await customerProvider.GetCustomersAsync();
            if (result.IsSuccess)
            {
                return Ok(result.Customers);
            }
            return NotFound(result.ErrorMessage);

        }

        [HttpGet("{customerId}")]
        public async Task<IActionResult> GetCustomerAsync(int customerId)
        {
            var result = await customerProvider.GetCustomerAsync(customerId);
            if (result.IsSuccess)
            {
                return Ok(result.Customer);
            }
            return NotFound(result.ErrorMessage);

        }
    }
}
