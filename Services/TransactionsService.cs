using System;
using Microsoft.AspNetCore.Mvc;
using CustomerBalanceApi.Models;
using CustomerBalanceApi.Services;
using CustomerBalanceApi.Services.TransactionsService;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;
using System.Data.Entity;



namespace CustomerBalanceApi.Services.TransactionsService
{
    public class TransactionsService : ITransactionsService
    {
        private readonly DataContext _context;

        public TransactionsService(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Transactions>GetAllTransactions(IEnumerable<Transactions> transactions)
        {

              return transactions.OrderBy(t => t.Transaction);

        }

        public async Task<Transactions> GetSingleTransactionByTransaction(DateTimeOffset transaction)
        {
            var transac = await _context.Transactions.Where(t => t.Transaction == transaction).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            return transac;
        }

        public async Task<Transactions> GetSingleTransactionByName(string name)
        {
            var transac = await _context.Transactions.Where(t => t.Name == name).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            return transac;
        }

        public async Task<Transactions> GetSingleTransactionByTelephone(string telephone)
        {
            var transac = await _context.Transactions.Where(t => t.Telephone == telephone).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            return transac;
        }

        public async Task<Transactions> GetSingleTransactionByEmailAddress(string emailaddress)
        {
            var transac = await _context.Transactions.Where(t => t.EmailAddress == emailaddress).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            return transac;
        }

        public async Task<Transactions> GetSingleTransactionByItemPurchased(string itempurchased)
        {
            var transac = await _context.Transactions.Where(t => t.ItemPurchased == itempurchased).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            return transac;
        }

        public async Task<Transactions> GetSingleTransactionByPriceOfItem(int priceofitem)
        {
            var transac = await _context.Transactions.Where(t => t.PriceOfItem == priceofitem).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            return transac;
        }

        public async Task<Transactions> GetSingleTransactionByTotalSumOfItems(Int64 totalsumofitems)
        {

            var transac = await _context.Transactions.Where(t => t.TotalSumOfItems == totalsumofitems).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            return transac;
        }

        public async Task<Transactions> GetSingleTransactionByAccountDebit(decimal accountdebit)
        {

            var transac = await _context.Transactions.Where(t => t.AccountDebit == accountdebit).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            return transac;
        }

        public async Task<Transactions> GetSingleTransactionByFirstPayment(decimal firstpayment)
        {

            var transac = await _context.Transactions.Where(t => t.FirstPayment == firstpayment).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            return transac;
        }

        public async Task<Transactions> GetSingleTransactionBySecondPayment(decimal secondpayment)
        {

            var transac = await _context.Transactions.Where(t => t.SecondPayment == secondpayment).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            return transac;
        }

        public async Task<Transactions> GetSingleTransactionByModeOfFirstPayment(string modeoffirstpayment)
        {

            var transac = await _context.Transactions.Where(t => t.ModeOfFirstPayment == modeoffirstpayment).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            return transac;
        }

        public async Task<Transactions> GetSingleTransactionByModeOfSecondPayment(string modeofsecondpayment)
        {

            var transac = await _context.Transactions.Where(t => t.ModeOfSecondPayment == modeofsecondpayment).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            return transac;
        }

        public async Task<Transactions> GetSingleTransactionByFirstPaymentAddress(string firstpaymentaddress)
        {

            var transac = await _context.Transactions.Where(t => t.FirstPaymentAddress == firstpaymentaddress).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            return transac;
        }

        public async Task<Transactions> GetSingleTransactionBySecondPaymentAddress(string secondpaymentaddress)
        {

            var transac = await _context.Transactions.Where(t => t.SecondPaymentAddress == secondpaymentaddress).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            return transac;
        }

        public async Task<Transactions> GetSingleTransactionByAccountCredit(decimal accountcredit)
        {

            var transac = await _context.Transactions.Where(t => t.AccountCredit == accountcredit).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            return transac;
        }

        public async Task<Transactions> GetSingleTransactionByCurrentBalance(decimal currentbalance)
        {

            var transac = await _context.Transactions.Where(t => t.CurrentBalance == currentbalance).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            return transac;
        }

        public async Task<ActionResult<List<Transactions>>> AddTransactions(Transactions transactions)
        {
            _context.Transactions.Add(transactions);
            await _context.SaveChangesAsync();

            return await _context.Transactions.ToListAsync();
        }

        public async Task<List<Transactions>> UpdateTransactionByTransaction(DateTimeOffset transaction, Transactions request)
        {
            var transac = await _context.Transactions.Where(t => t.Transaction == transaction).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            transac.Transaction = request.Transaction;
            await _context.SaveChangesAsync();

            return await _context.Transactions.ToListAsync();
        }

        public async Task<List<Transactions>> UpdateTransactionByName(string name, Transactions request)
        {
            var transac = await _context.Transactions.Where(t => t.Name == name).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            transac.Name = request.Name;
            await _context.SaveChangesAsync();

            return await _context.Transactions.ToListAsync();
        }

        public async Task<List<Transactions>> UpdateTransactionByTelephone(string telephone, Transactions request)
        {
            var transac = await _context.Transactions.Where(t => t.Telephone == telephone).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            transac.Telephone = request.Telephone;
            await _context.SaveChangesAsync();

            return await _context.Transactions.ToListAsync();
        }

        public async Task<List<Transactions>> UpdateTransactionByEmailAddress(string emailaddress, Transactions request)
        {
            var transac = await _context.Transactions.Where(t => t.EmailAddress == emailaddress).FirstOrDefaultAsync();
            return null;

            transac.EmailAddress = request.EmailAddress;
            await _context.SaveChangesAsync();

            return await _context.Transactions.ToListAsync();
        }

        public async Task<List<Transactions>> UpdateTransactionByItemPurchased(string itempurchased, Transactions request)
        {
            var transac = await _context.Transactions.Where(t => t.ItemPurchased == itempurchased).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            transac.ItemPurchased = request.ItemPurchased;
            await _context.SaveChangesAsync();

            return await _context.Transactions.ToListAsync();
        }

        public async Task<List<Transactions>> UpdateTransactionByPriceOfItem(int priceofitem, Transactions request)
        {
            var transac = await _context.Transactions.Where(t => t.PriceOfItem == priceofitem).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            transac.PriceOfItem = request.PriceOfItem;
            await _context.SaveChangesAsync();

            return await _context.Transactions.ToListAsync();
        }

        public async Task<List<Transactions>> UpdateTransactionByTotalSumOfItems(Int64 totalsumofitems, Transactions request)
        {
            var transac = await _context.Transactions.Where(t => t.TotalSumOfItems == totalsumofitems).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            transac.TotalSumOfItems = request.TotalSumOfItems;
            await _context.SaveChangesAsync();

            return await _context.Transactions.ToListAsync();
        }

        public async Task<List<Transactions>> UpdateTransactionByAccountDebit(decimal accountdebit, Transactions request)
        {
            var transac = await _context.Transactions.Where(t => t.AccountDebit == accountdebit).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            transac.AccountDebit = request.AccountDebit;
            await _context.SaveChangesAsync();

            return await _context.Transactions.ToListAsync();
        }

        public async Task<List<Transactions>> UpdateTransactionByFirstPayment(decimal firstpayment, Transactions request)
        {
            var transac = await _context.Transactions.Where(t => t.FirstPayment == firstpayment).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            transac.FirstPayment = request.FirstPayment;
            await _context.SaveChangesAsync();

            return await _context.Transactions.ToListAsync();
        }

        public async Task<List<Transactions>> UpdateTransactionBySecondPayment(decimal secondpayment, Transactions request)
        {
            var transac = await _context.Transactions.Where(t => t.SecondPayment == secondpayment).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            transac.SecondPayment = request.SecondPayment;
            await _context.SaveChangesAsync();

            return await _context.Transactions.ToListAsync();
        }

        public async Task<List<Transactions>> UpdateTransactionByModeOfFirstPayment(string modeoffirstpayment, Transactions request)
        {
            var transac = await _context.Transactions.Where(t => t.ModeOfFirstPayment == modeoffirstpayment).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            transac.ModeOfFirstPayment = request.ModeOfFirstPayment;
            await _context.SaveChangesAsync();

            return await _context.Transactions.ToListAsync();
        }

        public async Task<List<Transactions>> UpdateTransactionByModeOfSecondPayment(string modeofsecondpayment, Transactions request)
        {
            var transac = await _context.Transactions.Where(t => t.ModeOfSecondPayment == modeofsecondpayment).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            transac.ModeOfSecondPayment = request.ModeOfSecondPayment;
            await _context.SaveChangesAsync();

            return await _context.Transactions.ToListAsync();
        }

        public async Task<List<Transactions>> UpdateTransactionByFirstPaymentAddress(string firstpaymentaddress, Transactions request)
        {
            var transac = await _context.Transactions.Where(t => t.ModeOfSecondPayment == firstpaymentaddress).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            transac.FirstPaymentAddress = request.FirstPaymentAddress;
            await _context.SaveChangesAsync();

            return await _context.Transactions.ToListAsync();
        }

        public async Task<List<Transactions>> UpdateTransactionBySecondPaymentAddress(string secondpaymentaddress, Transactions request)
        {
            var transac = await _context.Transactions.Where(t => t.SecondPaymentAddress == secondpaymentaddress).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            transac.SecondPaymentAddress = request.SecondPaymentAddress;
            await _context.SaveChangesAsync();

            return await _context.Transactions.ToListAsync();
        }

        public async Task<List<Transactions>> UpdateTransactionByAccountCredit(decimal accountcredit, Transactions request)
        {
            var transac = await _context.Transactions.Where(t => t.AccountCredit == accountcredit).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            transac.AccountCredit = request.AccountCredit;
            await _context.SaveChangesAsync();

            return await _context.Transactions.ToListAsync();
        }

        public async Task<List<Transactions>> UpdateTransactionByCurrentBalance(decimal currentbalance, Transactions request)
        {
            var transac = await _context.Transactions.Where(t => t.CurrentBalance == currentbalance).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            transac.CurrentBalance = request.CurrentBalance;
            await _context.SaveChangesAsync();

            return await _context.Transactions.ToListAsync();
        }

        public async Task<List<Transactions>> DeleteTransactionByTransaction(DateTimeOffset transaction)
        {
            var transac = await _context.Transactions.Where(t => t.Transaction == transaction).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            _context.Transactions.Remove(transac);
            await _context.SaveChangesAsync();

            return await _context.Transactions.ToListAsync();

        }

        public async Task<List<Transactions>> DeleteTransactionByName(string name)
        {
            var transac = await _context.Transactions.Where(t => t.Name == name).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            _context.Transactions.Remove(transac);
            await _context.SaveChangesAsync();

            return await _context.Transactions.ToListAsync();

        }

        public async Task<List<Transactions>> DeleteTransactionByTelephone(string telephone)
        {
            var transac = await _context.Transactions.Where(t => t.Telephone == telephone).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            _context.Transactions.Remove(transac);
            await _context.SaveChangesAsync();

            return await _context.Transactions.ToListAsync();

        }

        public async Task<List<Transactions>> DeleteTransactionByEmailAddress(string emailaddress)
        {
            var transac = await _context.Transactions.Where(t => t.EmailAddress == emailaddress).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            _context.Transactions.Remove(transac);
            await _context.SaveChangesAsync();

            return await _context.Transactions.ToListAsync();

        }

        public async Task<List<Transactions>> DeleteTransactionByItemPurchased(string itempurchased)
        {
            var transac = await _context.Transactions.Where(t => t.ItemPurchased == itempurchased).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            _context.Transactions.Remove(transac);
            await _context.SaveChangesAsync();

            return await _context.Transactions.ToListAsync();

        }

        public async Task<List<Transactions>> DeleteTransactionByPriceOfItem(int priceofitem)
        {
            var transac = await _context.Transactions.Where(t => t.PriceOfItem == priceofitem).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            _context.Transactions.Remove(transac);
            await _context.SaveChangesAsync();

            return await _context.Transactions.ToListAsync();

        }

        public async Task<List<Transactions>> DeleteTransactionByTotalSumOfItems(Int64 totalsumofitems)
        {
            var transac = await _context.Transactions.Where(t => t.TotalSumOfItems == totalsumofitems).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            _context.Transactions.Remove(transac);
            await _context.SaveChangesAsync();

            return await _context.Transactions.ToListAsync();

        }

        public async Task<List<Transactions>> DeleteTransactionByAccountDebit(decimal accountdebit)
        {
            var transac = await _context.Transactions.Where(t => t.AccountDebit == accountdebit).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            _context.Transactions.Remove(transac);
            await _context.SaveChangesAsync();

            return await _context.Transactions.ToListAsync();

        }

        public async Task<List<Transactions>> DeleteTransactionByFirstPayment(decimal firstpayment)
        {
            var transac = await _context.Transactions.Where(t => t.FirstPayment == firstpayment).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            _context.Transactions.Remove(transac);
            await _context.SaveChangesAsync();

            return await _context.Transactions.ToListAsync();

        }

        public async Task<List<Transactions>> DeleteTransactionBySecondPayment(decimal secondpayment)
        {
            var transac = await _context.Transactions.Where(t => t.SecondPayment == secondpayment).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            _context.Transactions.Remove(transac);
            await _context.SaveChangesAsync();

            return await _context.Transactions.ToListAsync();

        }

        public async Task<List<Transactions>> DeleteTransactionByModeOfFirstPayment(string modeoffirstpayment)
        {
            var transac = await _context.Transactions.Where(t => t.ModeOfFirstPayment == modeoffirstpayment).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            _context.Transactions.Remove(transac);
            await _context.SaveChangesAsync();

            return await _context.Transactions.ToListAsync();

        }

        public async Task<List<Transactions>> DeleteTransactionByModeOfSecondPayment(string modeofsecondpayment)
        {
            var transac = await _context.Transactions.Where(t => t.ModeOfSecondPayment == modeofsecondpayment).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            _context.Transactions.Remove(transac);
            await _context.SaveChangesAsync();

            return await _context.Transactions.ToListAsync();

        }

        public async Task<List<Transactions>> DeleteTransactionByFirstPaymentAddress(string firstpaymentaddress)
        {
            var transac = await _context.Transactions.Where(t => t.FirstPaymentAddress == firstpaymentaddress).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            _context.Transactions.Remove(transac);
            await _context.SaveChangesAsync();

            return await _context.Transactions.ToListAsync();

        }

        public async Task<List<Transactions>> DeleteTransactionBySecondPaymentAddress(string secondpaymentaddress)
        {
            var transac = await _context.Transactions.Where(t => t.SecondPaymentAddress == secondpaymentaddress).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            _context.Transactions.Remove(transac);
            await _context.SaveChangesAsync();

            return await _context.Transactions.ToListAsync();

        }

        public async Task<List<Transactions>> DeleteTransactionByAccountCredit(decimal accountcredit)
        {
            var transac = await _context.Transactions.Where(t => t.AccountCredit == accountcredit).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            _context.Transactions.Remove(transac);
            await _context.SaveChangesAsync();

            return await _context.Transactions.ToListAsync();

        }

        public async Task<List<Transactions>> DeleteTransactionByCurrentBalance(decimal currentbalance)
        {
            var transac = await _context.Transactions.Where(t => t.CurrentBalance == currentbalance).FirstOrDefaultAsync();
            if (transac is null)
                return null;

            _context.Transactions.Remove(transac);
            await _context.SaveChangesAsync();

            return await _context.Transactions.ToListAsync();

        }
    }
}
