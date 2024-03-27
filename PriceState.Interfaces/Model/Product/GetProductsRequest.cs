using PriceState.Interfaces.Pagination;

namespace PriceState.Interfaces.Model.Product;

public class GetProductsRequest
{
    public string Name { get; set; }

    public Page Page { get; set; } = new Page();
}