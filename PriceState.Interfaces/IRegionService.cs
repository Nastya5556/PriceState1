using PriceState.Data.Models;
using PriceState.Interfaces.Model.Product;
using PriceState.Interfaces.Model.Region;

namespace PriceState.Interfaces;

public interface IRegionService
{
    Task<Region?> CreateRegionAsync(string name);

    Task<GetRegionsResponse> GetAllRegionAsync(GetRegionsRequest request);

    Task<GetRegionsResponse?> GetRegionAsync(GetRegionRequest request);

    Task RenameRegionAsync(int regionId, string name);

    Task DeleteRegionAsync(int regionId);
}