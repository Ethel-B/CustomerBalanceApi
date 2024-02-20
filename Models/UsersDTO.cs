namespace CustomerBalanceApi.Models
{
    public class UsersDTO
    {
        public required string Name { get; set; }

        public required string Telephone { get; set; }

        public required string EmailAddress { get; set; }

        public required string Gender { get; set; }

        public required string UserName { get; set; }

        public required string PasswordHash { get; set; }
    }
}
