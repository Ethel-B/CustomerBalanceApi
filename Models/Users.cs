namespace CustomerBalanceApi.Models
{
    public class Users
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Telephone { get; set; } 

        public string EmailAddress { get; set; } 

        public string Gender { get; set; }

       public string UserName { get; set; } 

        public string PasswordHash { get; set; }


        public List<Customers> Customers { get; set; }

        public List<Products> Products { get; set; }

        public List<Transactions> Transactions { get; set; }


        public string RefreshToken { get; set; }

        public DateTime TokenCreated { get; set; }

        public DateTime TokenExpires { get; set; }
    }
}
