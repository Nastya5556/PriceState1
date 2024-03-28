using PriceState.Data.Models;
using PriceState.Interfaces.Model.Product;

namespace PriceState.Interfaces;

public interface IProductService
{
    Task<Product?> CreateProductAsync( int unitId, string name);

    Task<GetProductsResponse> GetAllProductAsync(GetProductsRequest request);

    Task<GetProductsResponse?> GetProductAsync(GetProductRequest request);

    Task RenameProductAsync(long ProductId, string name);

    Task DeleteProductAsync(long ProductId);
}

