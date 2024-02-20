namespace CustomerBalanceApi.Models
{
    public class Customers
    {
        public int UsersId { get; set; }

        public Users Users { get; set; }

        public int Id { get; set; }

        public string Name { get; set; } 

        public string Telephone { get; set; } 

        public string EmailAddress { get; set; } 

        public string Gender { get; set; }

        public decimal CurrentBalance { get; set; }

    }
}
