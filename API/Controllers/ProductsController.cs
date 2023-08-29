using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController:ControllerBase
{
    private readonly IGenericRepository<Product> _productRepository;
    private readonly IGenericRepository<ProductType> _productTypeRepository;
    private readonly IGenericRepository<ProductBrand> _productBrandRepository;


    public ProductsController(IGenericRepository<Product> productRepository,
        IGenericRepository<ProductType> productTypeRepository,
        IGenericRepository<ProductBrand> productBrandRepository)
    {
        _productRepository = productRepository;
        _productTypeRepository = productTypeRepository;
        _productBrandRepository = productBrandRepository;
    }
    
    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<Product>>> GetAllProducts()
    {
        var products = await _productRepository.ListAllAsync();
        return Ok(products);
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetProduct(int id)
    {
        return await _productRepository.GetByIdAsync(id);
    }
    
    [HttpGet("brands")]
    public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetAllBrands()
    {
        var brands = await _productBrandRepository.ListAllAsync();

        return Ok(brands);
    }
    
    [HttpGet("types")]
    public async Task<ActionResult<IReadOnlyList<ProductType>>> GetAllTypes()
    {
        var types = await _productTypeRepository.ListAllAsync();

        return Ok(types);
    }
}