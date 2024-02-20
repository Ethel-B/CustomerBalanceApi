using Microsoft.AspNetCore.Mvc;


namespace CustomerBalanceApi.Services.ProductsService
{
    public interface IProductsService
    {
        public Task<List<Products>> GetAllProducts();

        public Task<Products> GetSingleProductByItem(string item);

        public Task<Products> GetSingleProductByPriceOfItem(int priceofitem);

        public Task<ActionResult<List<Products>>> AddProducts(Products products);

        public Task<List<Products>> UpdateProductByItem(string item, Products request);

        public Task<List<Products>> UpdateProductByPriceOfItem(int priceofitem, Products request);

        public Task<List<Products>> DeleteProductByItem(string item);

       public Task<List<Products>> DeleteProductByPriceOfItem(int priceofitem);
        }
} 


