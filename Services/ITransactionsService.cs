using Microsoft.AspNetCore.Mvc;


namespace CustomerBalanceApi.Services.TransactionsService
{
   public interface ITransactionsService
 {

        public IEnumerable<Transactions>GetAllTransactions(IEnumerable<Transactions> transactions);

        public Task<Transactions> GetSingleTransactionByTransaction(DateTimeOffset transaction);

        public Task<Transactions> GetSingleTransactionByName(string name);

        public Task<Transactions> GetSingleTransactionByTelephone(string telephone);

        public Task<Transactions> GetSingleTransactionByEmailAddress(string emailaddress);
           
     public Task<Transactions> GetSingleTransactionByItemPurchased(string itempurchased);

        public Task<Transactions> GetSingleTransactionByPriceOfItem(int priceofitem);

        public Task<Transactions> GetSingleTransactionByTotalSumOfItems(Int64 totalsumofitems);

        public Task<Transactions> GetSingleTransactionByAccountDebit(decimal accountdebit);

        public Task<Transactions> GetSingleTransactionByFirstPayment(decimal firstpayment);

        public Task<Transactions> GetSingleTransactionBySecondPayment(decimal secondpayment);

        public Task<Transactions> GetSingleTransactionByModeOfFirstPayment(string modeoffirstpayment);

        public Task<Transactions> GetSingleTransactionByModeOfSecondPayment(string modeofsecondpayment);

        public Task<Transactions> GetSingleTransactionByFirstPaymentAddress(string firstpaymentaddress);

        public Task<Transactions> GetSingleTransactionBySecondPaymentAddress(string secondpaymentaddress);

        public Task<Transactions> GetSingleTransactionByAccountCredit(decimal accountcredit);

        public Task<Transactions> GetSingleTransactionByCurrentBalance(decimal currentbalance);

        public Task<ActionResult<List<Transactions>>> AddTransactions(Transactions transactions);

        public Task<List<Transactions>> UpdateTransactionByTransaction(DateTimeOffset transaction, Transactions request);

        public Task<List<Transactions>> UpdateTransactionByName(string name, Transactions request);

        public Task<List<Transactions>> UpdateTransactionByTelephone(string telephone, Transactions request);

        public Task<List<Transactions>> UpdateTransactionByEmailAddress(string emailaddress, Transactions request);

        public Task<List<Transactions>> UpdateTransactionByItemPurchased(string itempurchased, Transactions request);

        public Task<List<Transactions>> UpdateTransactionByPriceOfItem(int priceofitem, Transactions request);

        public Task<List<Transactions>> UpdateTransactionByTotalSumOfItems(Int64 totalsumofitems, Transactions request);

        public Task<List<Transactions>> UpdateTransactionByAccountDebit(decimal accountdebit, Transactions request);

        public Task<List<Transactions>> UpdateTransactionByFirstPayment(decimal firstpayment, Transactions request);

        public Task<List<Transactions>> UpdateTransactionBySecondPayment(decimal secondpayment, Transactions request);

        public Task<List<Transactions>> UpdateTransactionByModeOfFirstPayment(string modeoffirstpayment, Transactions request);

        public Task<List<Transactions>> UpdateTransactionByModeOfSecondPayment(string modeofsecondpayment, Transactions request);

        public Task<List<Transactions>> UpdateTransactionByFirstPaymentAddress(string firstpaymentaddress, Transactions request);

        public Task<List<Transactions>> UpdateTransactionBySecondPaymentAddress(string secondpaymentaddress, Transactions request);

        public Task<List<Transactions>> UpdateTransactionByAccountCredit(decimal accountcredit, Transactions request);

        public Task<List<Transactions>> UpdateTransactionByCurrentBalance(decimal currentbalance, Transactions request);

        public Task<List<Transactions>> DeleteTransactionByTransaction(DateTimeOffset transaction);

        public Task<List<Transactions>> DeleteTransactionByName(string name);

        public Task<List<Transactions>> DeleteTransactionByTelephone(string telephone);

        public Task<List<Transactions>> DeleteTransactionByEmailAddress(string emailaddress);

        public Task<List<Transactions>> DeleteTransactionByItemPurchased(string itempurchased);

        public Task<List<Transactions>> DeleteTransactionByPriceOfItem(int priceofitem);

        public Task<List<Transactions>> DeleteTransactionByTotalSumOfItems(Int64 totalsumofitems);

        public Task<List<Transactions>> DeleteTransactionByAccountDebit(decimal accountdebit);

        public Task<List<Transactions>> DeleteTransactionByFirstPayment(decimal firstpayment);

        public Task<List<Transactions>> DeleteTransactionBySecondPayment(decimal secondpayment);

        public Task<List<Transactions>> DeleteTransactionByModeOfFirstPayment(string modeoffirstpayment);

        public Task<List<Transactions>> DeleteTransactionByModeOfSecondPayment(string modeofsecondpayment);

        public Task<List<Transactions>> DeleteTransactionByFirstPaymentAddress(string firstpaymentaddress);

        public Task<List<Transactions>> DeleteTransactionBySecondPaymentAddress(string secondpaymentaddress);

        public Task<List<Transactions>> DeleteTransactionByAccountCredit(decimal accountcredit);

        public Task<List<Transactions>> DeleteTransactionByCurrentBalance(decimal currentbalance);
            
        }
    }

    
