using Microsoft.AspNetCore.Mvc;


namespace CustomerBalanceApi.Services.CustomersService
{
    public interface ICustomersService
    {
        public Task<List<Customers>> GetAllCustomers();

        public Task<Customers> GetSingleCustomerByName(string name);

        public Task<Customers> GetSingleCustomerByTelephone(string telephone);

        public Task<Customers> GetSingleCustomerByEmailAddress(string emailaddress);

        public Task<Customers> GetSingleCustomerByGender(string gender);

        public Task<Customers> GetSingleCustomerByCurrentBalance(decimal currentbalance);

        public Task<ActionResult<List<Customers>>> AddCustomers(Customers customers);

        public Task<List<Customers>> UpdateCustomerByName(string name, Customers request);

        public Task<List<Customers>> UpdateCustomerByTelephone(string telephone, Customers request);

        public Task<List<Customers>> UpdateCustomerByEmailAddress(string emailaddress, Customers request);

        public Task<List<Customers>> UpdateCustomerByGender(string gender, Customers request);

        public Task<List<Customers>> UpdateCustomerByCurrentBalance(decimal currentbalance, Customers request);

        public Task<List<Customers>> DeleteCustomerByName(string name);

        public Task<List<Customers>> DeleteCustomerByTelephone(string telephone);

        public Task<List<Customers>> DeleteCustomerByEmailAddress(string emailaddress);

        public Task<List<Customers>> DeleteCustomerByGender(string gender);

        public Task<List<Customers>> DeleteCustomerByCurrentBalance(decimal currentbalance);
        
    }
}
    
