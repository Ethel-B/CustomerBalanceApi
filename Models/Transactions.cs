namespace CustomerBalanceApi.Models
{
    public class Transactions
    {
       public int UsersId { get; set; }

        public Users Users { get; set; }

        public int Id { get; set; }

        public DateTimeOffset Transaction { get; set; }

        public string Name { get; set; }

        public string Telephone { get; set; }

        public string EmailAddress { get; set; } 

        public string ItemPurchased { get; set; } 

        public int PriceOfItem { get; set; }

        public Int64 TotalSumOfItems { get; set; }

        public decimal AccountDebit { get; set; }

        public decimal FirstPayment { get; set; }

        public decimal SecondPayment { get; set; }

        public string ModeOfFirstPayment { get; set; }

        public string ModeOfSecondPayment { get; set; }

        public string FirstPaymentAddress {get; set; }

        public string SecondPaymentAddress { get; set; }

        public decimal AccountCredit { get; set; }

        public decimal CurrentBalance { get; set; }

    }
}
