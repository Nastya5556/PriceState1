using PriceState.Interfaces.Pagination;

namespace PriceState.Interfaces.Model.Unit;

public class GetUnitRequest
{
    public long? UnitId { get; set; } = null;

    public Page Page { get; set; } = new Page();
}