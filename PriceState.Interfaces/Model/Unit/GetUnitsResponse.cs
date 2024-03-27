using PriceState.Interfaces.Model.Region;
using PriceState.Interfaces.Pagination;

namespace PriceState.Interfaces.Model.Unit;

public class GetUnitsResponse
{
    public Page Page { get; set; } = new Page();

    public long Count { get; set; }

    public IReadOnlyCollection<UnitModel> Items { get; set; }
}