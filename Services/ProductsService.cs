using System;
using Microsoft.AspNetCore.Mvc;
using CustomerBalanceApi.Models;
using CustomerBalanceApi.Services;
using CustomerBalanceApi.Services.ProductsService;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;



namespace CustomerBalanceApi.Services.ProductsService
{
    public class ProductsService : IProductsService
    {
        private readonly DataContext _context;

        public ProductsService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Products>> GetAllProducts()
        {
            var products = await _context.Products.ToListAsync();
            return products;
        }

        public async Task<Products> GetSingleProductByItem(string item)
        {
            var product = await _context.Products.Where(p => p.Item == item).FirstOrDefaultAsync();
            if (product is null)
                return null;

            return product;
        }

        public async Task<Products> GetSingleProductByPriceOfItem(int priceofitem)
        {
            var product = await _context.Products.Where(p => p.PriceOfItem == priceofitem).FirstOrDefaultAsync();
            if (product is null)
                return null;

            return product;
        }

        public async Task<ActionResult<List<Products>>> AddProducts(Products products)
        {
            _context.Products.Add(products);
            await _context.SaveChangesAsync();
            return await _context.Products.ToListAsync();
        }

        public async Task<List<Products>> UpdateProductByItem(string item, Products request)
        {
            var product = await _context.Products.Where(p => p.Item == item).FirstOrDefaultAsync();
            if (product is null)
                return null;

            product.Item = request.Item;
            await _context.SaveChangesAsync();

            return await _context.Products.ToListAsync();
        }

        public async Task<List<Products>> UpdateProductByPriceOfItem(int priceofitem, Products request)
        {
            var product = await _context.Products.Where(p => p.PriceOfItem == priceofitem).FirstOrDefaultAsync();
            if (product is null)
                return null;

            product.PriceOfItem = request.PriceOfItem;
            await _context.SaveChangesAsync();

            return await _context.Products.ToListAsync();
        }

        public async Task<List<Products>> DeleteProductByItem(string item)
        {
            var product = await _context.Products.Where(p => p.Item == item).FirstOrDefaultAsync();
            if (product is null)
                return null;

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return await _context.Products.ToListAsync();

        }

        public async Task<List<Products>> DeleteProductByPriceOfItem(int priceofitem)
        {
            var product = await _context.Products.Where(p => p.PriceOfItem == priceofitem).FirstOrDefaultAsync();
            if (product is null)
                return null;

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return await _context.Products.ToListAsync();

        }
    }
}