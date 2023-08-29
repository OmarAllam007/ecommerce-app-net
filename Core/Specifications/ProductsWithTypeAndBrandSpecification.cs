using Core.Entities;

namespace Core.Specifications;

public class ProductsWithTypeAndBrandSpecification : BaseSpecification<Product>
{
    public ProductsWithTypeAndBrandSpecification()
    {
        AddInclude(p => p.ProductType);
        AddInclude(p => p.ProductBrand);
    }

    public ProductsWithTypeAndBrandSpecification(int id) : base(p => p.Id == id)
    {
        AddInclude(p => p.ProductType);
        AddInclude(p => p.ProductBrand);
    }
}