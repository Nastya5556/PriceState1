using PriceState.Interfaces.Pagination;

namespace PriceState.Interfaces.Model.Region;

public class GetRegionsRequest
{
    public Page Page { get; set; } = new Page();
}