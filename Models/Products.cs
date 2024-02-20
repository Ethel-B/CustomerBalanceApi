namespace CustomerBalanceApi.Models
{
    public class Products
    { 
      public int UsersId { get; set; }

        public Users Users { get; set; }

        public int Id { get; set; }

        public string Item { get; set; }

        public int PriceOfItem { get; set; }
      
    }
}
