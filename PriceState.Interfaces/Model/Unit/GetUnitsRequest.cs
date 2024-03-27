using PriceState.Interfaces.Pagination;

namespace PriceState.Interfaces.Model.Unit;

public class GetUnitsRequest
{
    public Page Page { get; set; } = new Page();
}