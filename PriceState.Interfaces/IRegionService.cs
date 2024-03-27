using PriceState.Data.Models;
using PriceState.Interfaces.Model.Product;
using PriceState.Interfaces.Model.Region;

namespace PriceState.Interfaces;

public class IRegionService
{
    Task<Region?> CreateRegionAsync(string name);

    Task<GetRegionsResponse> GetAllRegionAsync(GetRegionsRequest request);

    Task<Region?> GetRegionAsync(GetRegionRequest request);

    Task RenameRegionAsync(long RegionId, string name);

    Task DeleteRegionAsync(long RegionId);
}