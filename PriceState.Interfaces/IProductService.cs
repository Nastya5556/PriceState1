using PriceState.Data.Models;
using PriceState.Interfaces.Model.Product;

namespace PriceState.Interfaces;

public class IProductService
{
    Task<Product?> CreateProductAsync(string name);

    Task<GetProductsResponse> GetAllProductAsync(GetProductsRequest request);

    Task<Product?> GetProductAsync(GetProductRequest request);

    Task RenameProductAsync(long ProductId, string name);

    Task DeleteProductAsync(long ProductId);
}

