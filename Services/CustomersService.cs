using System;
using Microsoft.AspNetCore.Mvc;
using CustomerBalanceApi.Models;
using CustomerBalanceApi.Services;
using CustomerBalanceApi.Services.CustomersService;
using Microsoft.EntityFrameworkCore;



namespace CustomerBalanceApi.Services.CustomersService
{
    public class CustomersService : ICustomersService
    {
        private readonly DataContext _context;

        public CustomersService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Customers>> GetAllCustomers()
        {
            var customers = await _context.Customers.ToListAsync();
            return customers;
        }

        public async Task<Customers> GetSingleCustomerByName(string name)
        {
            var customer = await _context.Customers.Where(c => c.Name == name).FirstOrDefaultAsync();
            if (customer is null)
                return null;

            return customer;
        }

        public async Task<Customers> GetSingleCustomerByTelephone(string telephone)
        {
            var customer = await _context.Customers.Where(c => c.Telephone == telephone).FirstOrDefaultAsync();
            if (customer is null)
                return null;

            return customer;
        }

        public async Task<Customers> GetSingleCustomerByEmailAddress(string emailaddress)
        {
            var customer = await _context.Customers.Where(c => c.EmailAddress == emailaddress).FirstOrDefaultAsync();
            if (customer is null)
                return null;

            return customer;
        }

        public async Task<Customers> GetSingleCustomerByGender(string gender)
        {
            var customer = await _context.Customers.Where(c => c.Gender == gender).FirstOrDefaultAsync();
            if (customer is null)
                return null;

            return customer;
        }

        public async Task<Customers> GetSingleCustomerByCurrentBalance(decimal currentbalance)
        {
            var customer = await _context.Customers.Where(c => c.CurrentBalance == currentbalance).FirstOrDefaultAsync();
            if (customer is null)
                return null;

            return customer;
        }

        public async Task<ActionResult<List<Customers>>> AddCustomers(Customers customers)
        {
            _context.Customers.Add(customers);
            await _context.SaveChangesAsync();
            return await _context.Customers.ToListAsync();
        }

        public async Task<List<Customers>> UpdateCustomerByName(string name, Customers request)
        {
            var customer = await _context.Customers.Where(c => c.Name == name).FirstOrDefaultAsync();
            if (customer is null)
                return null;

            customer.Name = request.Name;
            await _context.SaveChangesAsync();

            return await _context.Customers.ToListAsync();
        }

        public async Task<List<Customers>> UpdateCustomerByTelephone(string telephone, Customers request)
        {
            var customer = await _context.Customers.Where(c => c.Telephone == telephone).FirstOrDefaultAsync();
            if (customer is null)
                return null;

            customer.Telephone = request.Telephone;
            await _context.SaveChangesAsync();

            return await _context.Customers.ToListAsync();
        }

        public async Task<List<Customers>> UpdateCustomerByEmailAddress(string emailaddress, Customers request)
        {
            var customer = await _context.Customers.Where(c => c.EmailAddress == emailaddress).FirstOrDefaultAsync();
            if (customer is null)
                return null;

            customer.EmailAddress = request.EmailAddress;
            await _context.SaveChangesAsync();

            return await _context.Customers.ToListAsync();
        }

        public async Task<List<Customers>> UpdateCustomerByGender(string gender, Customers request)
        {
            var customer = await _context.Customers.Where(c => c.Gender == gender).FirstOrDefaultAsync();
            if (customer is null)
                return null;

            customer.Gender = request.Gender;
            await _context.SaveChangesAsync();

            return await _context.Customers.ToListAsync();
        }

        public async Task<List<Customers>> UpdateCustomerByCurrentBalance(decimal currentbalance, Customers request)
        {
            var customer = await _context.Customers.Where(c => c.CurrentBalance == currentbalance).FirstOrDefaultAsync();
            if (customer is null)
                return null;

            customer.CurrentBalance = request.CurrentBalance;
            await _context.SaveChangesAsync();

            return await _context.Customers.ToListAsync();
        }

        public async Task<List<Customers>> DeleteCustomerByName(string name)
        {
            var customer = await _context.Customers.Where(c => c.Name == name).FirstOrDefaultAsync();
            if (customer is null)
                return null;

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();

            return await _context.Customers.ToListAsync();

        }

        public async Task<List<Customers>> DeleteCustomerByTelephone(string telephone)
        {
            var customer = await _context.Customers.Where(c => c.Telephone == telephone).FirstOrDefaultAsync();
            if (customer is null)
                return null;

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();

            return await _context.Customers.ToListAsync();

        }

        public async Task<List<Customers>> DeleteCustomerByEmailAddress(string emailaddress)
        {
            var customer = await _context.Customers.Where(c => c.EmailAddress == emailaddress).FirstOrDefaultAsync();
            if (customer is null)
                return null;

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();

            return await _context.Customers.ToListAsync();

        }

        public async Task<List<Customers>> DeleteCustomerByGender(string gender)
        {
            var customer = await _context.Customers.Where(c => c.Gender == gender).FirstOrDefaultAsync();
            if (customer is null)
                return null;

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();

            return await _context.Customers.ToListAsync();

        }

        public async Task<List<Customers>> DeleteCustomerByCurrentBalance(decimal currentbalance)
        {
            var customer = await _context.Customers.Where(c => c.CurrentBalance == currentbalance).FirstOrDefaultAsync();
            if (customer is null)
                return null;

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();

            return await _context.Customers.ToListAsync();

        }
    }
}