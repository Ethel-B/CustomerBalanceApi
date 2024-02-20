using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using CustomerBalanceApi.Models;
using CustomerBalanceApi.Data;
using CustomerBalanceApi.Services;
using CustomerBalanceApi.Services.ProductsService;



namespace CustomerBalanceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }


        [HttpGet]
        public async Task<ActionResult<List<Products>>> GetAllProducts()
        {
            return await _productsService.GetAllProducts();
        }

        [HttpGet("GetSingleProductByItem/{Item}")]
        public async Task<ActionResult<Products>> GetSingleProductByItem(string item)
        {
            var result = await _productsService.GetSingleProductByItem(item);
            if (result is null)
                return NotFound("Product not found.");

            return Ok(result);

        }

        [HttpGet("GetSingleProductByPriceOfItem/{PriceOfItem}")]
        public async Task<ActionResult<Products>> GetSingleProductByPriceOfItem(int priceofitem)
        {
            var result = await _productsService.GetSingleProductByPriceOfItem(priceofitem);
            if (result is null)
                return NotFound("Product not found.");

            return Ok(result);

        }

        [HttpPost]
        public async Task<ActionResult<List<Products>>> AddProducts(Products products)
        {
            var result = await _productsService.AddProducts(products);
            return Ok(result);
        }

        [HttpPut("UpdateProductByItem/{Item}")]
        public async Task<ActionResult<List<Products>>> UpdateProductByItem(string item, Products request)
        {
            var result = await _productsService.UpdateProductByItem(item, request);
            if (result is null)
                return NotFound("Product not found.");

            return Ok(result);
        }

        [HttpPut("UpdateProductByPriceOfItem/{PriceOfItem}")]
        public async Task<ActionResult<List<Products>>> UpdateProductByPriceOfItem(int priceofitem, Products request)
        {
            var result = await _productsService.UpdateProductByPriceOfItem(priceofitem, request);
            if (result is null)
                return NotFound("Product not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteProductByItem/{Item}")]
        public async Task<ActionResult<List<Products>>> DeleteProductByItem(string item)
        {
            var result = await _productsService.DeleteProductByItem(item);
            if (result is null)
                return NotFound("Customer not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteProductByPriceOfItem/{PriceOfItem}")]
        public async Task<ActionResult<List<Products>>> DeleteProductByPriceOfItem(int priceofitem)
        {
            var result = await _productsService.DeleteProductByPriceOfItem(priceofitem);
            if (result is null)
                return NotFound("Customer not found.");

            return Ok(result);

        }

    }
    }

