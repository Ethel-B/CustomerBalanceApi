using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using CustomerBalanceApi.Models;
using CustomerBalanceApi.Data;
using CustomerBalanceApi.Services;
using CustomerBalanceApi.Services.TransactionsService;
using CustomerBalanceApi.Migrations;
using Microsoft.AspNetCore.Http.HttpResults;
using Transactions = CustomerBalanceApi.Models.Transactions;
using System.Net.Mail;




namespace CustomerBalanceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionsService _transactionsService;

        public TransactionsController(ITransactionsService transactionsService)
        {
            _transactionsService = transactionsService;
        }


        [HttpGet]
        public IEnumerable<Transactions> GetAllTransactions(IEnumerable<Transactions> transactions)
        {

            return transactions.OrderBy(t => t.Transaction);

        }

        [HttpGet("GetSingleTransactionByTransaction/{Transaction}")]
        public async Task<ActionResult<Transactions>> GetSingleTransactioByTransaction(DateTimeOffset transaction)
        {
            var result = await _transactionsService.GetSingleTransactionByTransaction(transaction);
            if (result is null)
                return NotFound("Transaction not found.");

            return Ok(result);

        }

        [HttpGet("GetSingleTransactionByName/{Name}")]
        public async Task<ActionResult<Transactions>> GetSingleTransactioByName(string name)
        {
            var result = await _transactionsService.GetSingleTransactionByName(name);
            if (result is null)
                return NotFound("Transaction not found.");

            return Ok(result);

        }

        [HttpGet("GetSingleTransactionByTelephone/{Telephone}")]
        public async Task<ActionResult<Transactions>> GetSingleTransactioByTelephone(string telephone)
        {
            var result = await _transactionsService.GetSingleTransactionByTelephone(telephone);
            if (result is null)
                return NotFound("Transaction not found.");

            return Ok(result);

        }

        [HttpGet("GetSingleTransactionByEmailAddress/{EmailAddress}")]
        public async Task<ActionResult<Transactions>> GetSingleTransactioByEmailAddress(string emailaddress)
        {
            var result = await _transactionsService.GetSingleTransactionByEmailAddress(emailaddress);
            if (result is null)
                return NotFound("Transaction not found.");

            return Ok(result);

        }

        [HttpGet("GetSingleTransactionByItemPurchased/{ItemPurchased}")]
        public async Task<ActionResult<Transactions>> GetSingleTransactioByItemPurchased(string itempurchased)
        {
            var result = await _transactionsService.GetSingleTransactionByItemPurchased(itempurchased);
            if (result is null)
                return NotFound("Transaction not found.");

            return Ok(result);

        }

        [HttpGet("GetSingleTransactionByPriceOfItem/{PriceOfItem}")]
        public async Task<ActionResult<Transactions>> GetSingleTransactioByPriceOfItem(int priceofitem)
        {
            var result = await _transactionsService.GetSingleTransactionByPriceOfItem(priceofitem);
            if (result is null)
                return NotFound("Transaction not found.");

            return Ok(result);

        }

        [HttpGet("GetSingleTransactionByTotalSumOfItems/{TotalSumOfItems}")]
        public async Task<ActionResult<Transactions>> GetSingleTransactioByTotalSumOfItems(Int64 totalsumofitems)
        {
            var result = await _transactionsService.GetSingleTransactionByTotalSumOfItems(totalsumofitems);
            if (result is null)
                return NotFound("Transaction not found.");

            return Ok(result);

        }

        [HttpGet("GetSingleTransactionByAccountDebit/{AccountDebit}")]
        public async Task<ActionResult<Transactions>> GetSingleTransactioByAccountDebit(decimal accountdebit)
        {
            var result = await _transactionsService.GetSingleTransactionByAccountDebit(accountdebit);
            if (result is null)
                return NotFound("Transaction not found.");

            return Ok(result);

        }

        [HttpGet("GetSingleTransactionByFirstPayment/{FirstPayment}")]
        public async Task<ActionResult<Transactions>> GetSingleTransactioByFirstPayment(decimal firstpayment)
        {
            var result = await _transactionsService.GetSingleTransactionByFirstPayment(firstpayment);
            if (result is null)
                return NotFound("Transaction not found.");

            return Ok(result);

        }

        [HttpGet("GetSingleTransactionBySecondPayment/{SecondPayment}")]
        public async Task<ActionResult<Transactions>> GetSingleTransactioBySecondPayment(decimal secondpayment)
        {
            var result = await _transactionsService.GetSingleTransactionBySecondPayment(secondpayment);
            if (result is null)
                return NotFound("Transaction not found.");

            return Ok(result);

        }

        [HttpGet("GetSingleTransactionByModeOfFirstPayment/{ModeOfFirstPayment}")]
        public async Task<ActionResult<Transactions>> GetSingleTransactioByModeOfFirstPayment(string modeoffirstpayment)
        {
            var result = await _transactionsService.GetSingleTransactionByModeOfFirstPayment(modeoffirstpayment);
            if (result is null)
                return NotFound("Transaction not found.");

            return Ok(result);

        }

        [HttpGet("GetSingleTransactionByModeOfSecondPayment/{ModeOfSecondPayment}")]
        public async Task<ActionResult<Transactions>> GetSingleTransactioByModeOfSecondPayment(string modeofsecondpayment)
        {
            var result = await _transactionsService.GetSingleTransactionByModeOfSecondPayment(modeofsecondpayment);
            if (result is null)
                return NotFound("Transaction not found.");

            return Ok(result);

        }

        [HttpGet("GetSingleTransactionByFirstPaymentAddress/{FirstPaymentAddress}")]
        public async Task<ActionResult<Transactions>> GetSingleTransactioByFirstPaymentAddress(string firstpaymentaddress)
        {
            var result = await _transactionsService.GetSingleTransactionByFirstPaymentAddress(firstpaymentaddress);
            if (result is null)
                return NotFound("Transaction not found.");

            return Ok(result);

        }

        [HttpGet("GetSingleTransactionBySecondPaymentAddress/{SecondPaymentAddress}")]
        public async Task<ActionResult<Transactions>> GetSingleTransactioBySecondPaymentAddress(string secondpaymentaddress)
        {
            var result = await _transactionsService.GetSingleTransactionBySecondPaymentAddress(secondpaymentaddress);
            if (result is null)
                return NotFound("Transaction not found.");

            return Ok(result);

        }

        [HttpGet("GetSingleTransactionByAccountCredit/{AccountCredit}")]
        public async Task<ActionResult<Transactions>> GetSingleTransactioByAccountCredit(decimal accountcredit)
        {
            var result = await _transactionsService.GetSingleTransactionByAccountCredit(accountcredit);
            if (result is null)
                return NotFound("Transaction not found.");

            return Ok(result);

        }

        [HttpGet("GetSingleTransactionByCurrentBalance/{CurrentBalance}")]
        public async Task<ActionResult<Transactions>> GetSingleTransactioByCurrentBalance(decimal currentbalance)
        {
            var result = await _transactionsService.GetSingleTransactionByCurrentBalance(currentbalance);
            if (result is null)
                return NotFound("Transaction not found.");

            return Ok(result);

        }

        [HttpPost]
        public async Task<ActionResult<List<Transactions>>> AddTransactions(Transactions transactions)
        {
            var result = await _transactionsService.AddTransactions(transactions);
            return Ok(result);
        }

        [HttpPut("UpdateTransactionByTransaction/{Transaction}")]
        public async Task<ActionResult<List<Transactions>>> UpdateTransactionByTransaction(DateTimeOffset transaction, Transactions request)
        {
            var result = await _transactionsService.UpdateTransactionByTransaction(transaction, request);
            if (result is null)
                return NotFound("Transaction unsuccessful.");

            return Ok(result);
        }

        [HttpPut("UpdateTransactionByName/{Name}")]
        public async Task<ActionResult<List<Transactions>>> UpdateTransactionByName(string name, Transactions request)
        {
            var result = await _transactionsService.UpdateTransactionByName(name, request);
            if (result is null)
                return NotFound("Transaction unsuccessful.");

            return Ok(result);
        }

        [HttpPut("UpdateTransactionByTelephone/{Telephone}")]
        public async Task<ActionResult<List<Transactions>>> UpdateTransactionByTelephone(string telephone, Transactions request)
        {
            var result = await _transactionsService.UpdateTransactionByTelephone(telephone, request);
            if (result is null)
                return NotFound("Transaction unsuccessful.");

            return Ok(result);
        }

        [HttpPut("UpdateTransactionByEmailAddress/{EmailAddress}")]
        public async Task<ActionResult<List<Transactions>>> UpdateTransactionByEmailAddress(string emailaddress, Transactions request)
        {
            var result = await _transactionsService.UpdateTransactionByEmailAddress(emailaddress, request);
            if (result is null)
                return NotFound("Transaction unsuccessful.");

            return Ok(result);
        }

        [HttpPut("UpdateTransactionByItemPurchased/{ItemPurchased}")]
        public async Task<ActionResult<List<Transactions>>> UpdateTransactionByItemPurchased(string itempurchased, Transactions request)
        {
            var result = await _transactionsService.UpdateTransactionByItemPurchased(itempurchased, request);
            if (result is null)
                return NotFound("Transaction unsuccessful.");

            return Ok(result);
        }

        [HttpPut("UpdateTransactionByPriceOfItem/{PriceOfItem}")]
        public async Task<ActionResult<List<Transactions>>> UpdateTransactionByPriceOfItem(int priceofitem, Transactions request)
        {
            var result = await _transactionsService.UpdateTransactionByPriceOfItem(priceofitem, request);
            if (result is null)
                return NotFound("Transaction unsuccessful.");

            return Ok(result);
        }

        [HttpPut("UpdateTransactionByTotalSumOfItems/{TotalSumOfItems}")]
        public async Task<ActionResult<List<Transactions>>> UpdateTransactionByTotalSumOfItems(Int64 totalsumofitems, Transactions request)
        {
            var result = await _transactionsService.UpdateTransactionByTotalSumOfItems(totalsumofitems, request);
            if (result is null)
                return NotFound("Transaction unsuccessful.");

            return Ok(result);
        }

        [HttpPut("UpdateTransactionByAccountDebit/{AccountDebit}")]
        public async Task<ActionResult<List<Transactions>>> UpdateTransactionByAccountDebit(decimal accountdebit, Transactions request)
        {
            var result = await _transactionsService.UpdateTransactionByAccountDebit(accountdebit, request);
            if (result is null)
                return NotFound("Transaction unsuccessful.");

            return Ok(result);
        }

        [HttpPut("UpdateTransactionByFirstPayment/{FirstPayment}")]
        public async Task<ActionResult<List<Transactions>>> UpdateTransactionByFirstPayment(decimal firstpayment, Transactions request)
        {
            var result = await _transactionsService.UpdateTransactionByFirstPayment(firstpayment, request);
            if (result is null)
                return NotFound("Transaction unsuccessful.");

            return Ok(result);
        }

        [HttpPut("UpdateTransactionBySecondPayment/{SecondPayment}")]
        public async Task<ActionResult<List<Transactions>>> UpdateTransactionBySecondPayment(decimal secondpayment, Transactions request)
        {
            var result = await _transactionsService.UpdateTransactionBySecondPayment(secondpayment, request);
            if (result is null)
                return NotFound("Transaction unsuccessful.");

            return Ok(result);
        }

        [HttpPut("UpdateTransactionByModeOfFirstPayment/{ModeOfFirstPayment}")]
        public async Task<ActionResult<List<Transactions>>> UpdateTransactionByModeOfFirstPayment(string modeoffirstpayment, Transactions request)
        {
            var result = await _transactionsService.UpdateTransactionByModeOfFirstPayment(modeoffirstpayment, request);
            if (result is null)
                return NotFound("Transaction unsuccessful.");

            return Ok(result);
        }

        [HttpPut("UpdateTransactionByModeOfSecondPayment/{ModeOfSecondPayment}")]
        public async Task<ActionResult<List<Transactions>>> UpdateTransactionByModeOfSecondPayment(string modeofsecondpayment, Transactions request)
        {
            var result = await _transactionsService.UpdateTransactionByModeOfSecondPayment(modeofsecondpayment, request);
            if (result is null)
                return NotFound("Transaction unsuccessful.");

            return Ok(result);
        }

        [HttpPut("UpdateTransactionByFirstPaymentAddress/{FirstPaymentAddress}")]
        public async Task<ActionResult<List<Transactions>>> UpdateTransactionByFirstPaymentAddress(string firstpaymentaddress, Transactions request)
        {
            var result = await _transactionsService.UpdateTransactionByFirstPaymentAddress(firstpaymentaddress, request);
            if (result is null)
                return NotFound("Transaction unsuccessful.");

            return Ok(result);
        }

        [HttpPut("UpdateTransactionBySecondPaymentAddress/{SecondPaymentAddress}")]
        public async Task<ActionResult<List<Transactions>>> UpdateTransactionBySecondPaymentAddress(string secondpaymentaddress, Transactions request)
        {
            var result = await _transactionsService.UpdateTransactionBySecondPaymentAddress(secondpaymentaddress, request);
            if (result is null)
                return NotFound("Transaction unsuccessful.");

            return Ok(result);
        }

        [HttpPut("UpdateTransactionByAccountCredit/{AccountCredit}")]
        public async Task<ActionResult<List<Transactions>>> UpdateTransactionByAccountCredit(decimal accountcredit, Transactions request)
        {
            var result = await _transactionsService.UpdateTransactionByAccountCredit(accountcredit, request);
            if (result is null)
                return NotFound("Transaction unsuccessful.");

            return Ok(result);
        }

        [HttpPut("UpdateTransactionByCurrentBalance/{CurrentBalance}")]
        public async Task<ActionResult<List<Transactions>>> UpdateTransactionByCurrentBalance(decimal currentbalance, Transactions request)
        {
            var result = await _transactionsService.UpdateTransactionByCurrentBalance(currentbalance, request);
            if (result is null)
                return NotFound("Transaction unsuccessful.");

            return Ok(result);
        }
    }
}

