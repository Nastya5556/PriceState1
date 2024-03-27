using PriceState.Data.Models;
using PriceState.Interfaces.Model.Organization;
using PriceState.Interfaces.Model.Product;

namespace PriceState.Interfaces;

public class IOrganizationService
{
    Task<Organization?> CreateOrganizationAsync(string name);

    Task<GetOrganizationsResponse> GetAllOrganizationAsync(GetOrganizationsRequest request);

    Task<Organization?> GetOrganizationAsync(GetOrganizationRequest request);

    Task RenameOrganizationAsync(long ProductId, string name);

    Task DeleteOrganizationAsync(long ProductId);
}