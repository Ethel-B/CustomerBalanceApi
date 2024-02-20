using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using CustomerBalanceApi.Models;
using CustomerBalanceApi.Data;
using CustomerBalanceApi.Services;
using CustomerBalanceApi.Services.CustomersService;
    
    

namespace CustomerBalanceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomersService _customersService;

        public CustomersController(ICustomersService customersService)
        {
            _customersService = customersService;
        }


        [HttpGet]
        public async Task<ActionResult<List<Customers>>> GetAllCustomers()
        {
            return await _customersService.GetAllCustomers();
        }

        [HttpGet("GetSingleCustomerByName/{Name}")]
        public async Task<ActionResult<Customers>> GetSingleCustomerByName(string name)
        {
            var result = await _customersService.GetSingleCustomerByName(name);
            if (result is null)
                return NotFound("Customer not found.");

            return Ok(result);

        }

        [HttpGet("GetSingleCustomerByTelephone/{Telephone}")]
        public async Task<ActionResult<Customers>> GetSingleCustomerByTelephone(string telephone)
        {
            var result = await _customersService.GetSingleCustomerByTelephone(telephone);
            if (result is null)
                return NotFound("Customer not found.");

            return Ok(result);

        }

        [HttpGet("GetSingleCustomerByEmailAddress/{EmailAddress}")]
        public async Task<ActionResult<Customers>> GetSingleCustomerByEmailAddress(string emailaddress)
        {
            var result = await _customersService.GetSingleCustomerByEmailAddress(emailaddress);
            if (result is null)
                return NotFound("Customer not found.");

            return Ok(result);

        }

        [HttpGet("GetSingleCustomerByGender/{Gender}")]
        public async Task<ActionResult<Customers>> GetSingleCustomerByGender(string gender)
        {
            var result = await _customersService.GetSingleCustomerByGender(gender);
            if (result is null)
                return NotFound("Customer not found.");

            return Ok(result);

        }

        [HttpGet("GetSingleCustomerByCurrentBalance/{CurrentBalance}")]
        public async Task<ActionResult<Customers>> GetSingleCustomerByCurrentBalance(decimal currentbalance)
        {
            var result = await _customersService.GetSingleCustomerByCurrentBalance(currentbalance);
            if (result is null)
                return NotFound("Customer not found.");

            return Ok(result);

        }

        [HttpPost]
        public async Task<ActionResult<List<Customers>>> AddCustomers(Customers customers)
        {
            var result = await _customersService.AddCustomers(customers);
            return Ok(result);
        }


        [HttpPut("UpdateCustomerByName/{Name}")]
        public async Task<ActionResult<List<Customers>>> UpdateCustomerByName(string name, Customers request)
        {
            var result = await _customersService.UpdateCustomerByName(name, request);
            if (result is null)
                return NotFound("Customer not found.");

            return Ok(result);
        }

        [HttpPut("UpdateCustomerByTelephone/{Telephone}")]
        public async Task<ActionResult<List<Customers>>> UpdateCustomerByTelephone(string telephone, Customers request)
        {
            var result = await _customersService.UpdateCustomerByTelephone(telephone, request);
            if (result is null)
                return NotFound("Customer not found.");

            return Ok(result);
        }

        [HttpPut("UpdateCustomerByEmailAddress/{EmailAddress}")]
        public async Task<ActionResult<List<Customers>>> UpdateCustomerByEmailAddress(string emailaddress, Customers request)
        {
            var result = await _customersService.UpdateCustomerByEmailAddress(emailaddress, request);
            if (result is null)
                return NotFound("Customer not found.");

            return Ok(result);
        }

        [HttpPut("UpdateCustomerByGender/{Gender}")]
        public async Task<ActionResult<List<Customers>>> UpdateCustomerByGender(string gender, Customers request)
        {
            var result = await _customersService.UpdateCustomerByGender(gender, request);
            if (result is null)
                return NotFound("Customer not found.");

            return Ok(result);
        }

        [HttpPut("UpdateCustomerByCurrentBalance/{CurrentBalance}")]
        public async Task<ActionResult<List<Customers>>> UpdateCustomerByCurrentBalance(decimal currentbalance, Customers request)
        {
            var result = await _customersService.UpdateCustomerByCurrentBalance(currentbalance, request);
            if (result is null)
                return NotFound("Customer not found.");

            return Ok(result);
        }

       [HttpDelete("DeleteCustomerByName/{Name}")]
        public async Task<ActionResult<List<Customers>>> DeleteCustomerByName(string name)
        {
            var result = await _customersService.DeleteCustomerByName(name);
            if (result is null)
                return NotFound("Customer not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteCustomerByTelephone/{Telephone}")]
        public async Task<ActionResult<List<Customers>>> DeleteCustomerByTelephone(string telephone)
        {
            var result = await _customersService.DeleteCustomerByTelephone(telephone);
            if (result is null)
                return NotFound("Customer not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteCustomerByEmailAddress/{EmailAddress}")]
        public async Task<ActionResult<List<Customers>>> DeleteCustomerByEmailAddress(string emailaddress)
        {
            var result = await _customersService.DeleteCustomerByEmailAddress(emailaddress);
            if (result is null)
                return NotFound("Customer not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteCustomerByGender/{Gender}")]
        public async Task<ActionResult<List<Customers>>> DeleteCustomerByGender(string gender)
        {
            var result = await _customersService.DeleteCustomerByGender(gender);
            if (result is null)
                return NotFound("Customer not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteCustomerByCurrentBalance/{CurrentBalance}")]
        public async Task<ActionResult<List<Customers>>> DeleteCustomerByCurrentBalance(decimal currentbalance)
        {
            var result = await _customersService.DeleteCustomerByCurrentBalance(currentbalance);
            if (result is null)
                return NotFound("Customer not found.");

            return Ok(result);

        }

    }
}

