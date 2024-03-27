using PriceState.Data.Models;
using PriceState.Interfaces.Model.Region;
using PriceState.Interfaces.Model.Unit;

namespace PriceState.Interfaces;

public class IUnitService
{
    Task<Unit?> CreateUnitAsync(string name);

    Task<GetUnitsResponse> GetAllUnitAsync(GetUnitsRequest request);

    Task<Unit?> GetUnitAsync(GetUnitRequest request);

    Task RenameUnitAsync(long UnitId, string name);

    Task DeleteUnitAsync(long UnitId);
}