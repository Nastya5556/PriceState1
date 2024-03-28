using PriceState.Data.Models;
using PriceState.Interfaces.Model.Organization;
using PriceState.Interfaces.Model.Product;

namespace PriceState.Interfaces;

public interface IOrganizationService
{
   Task<Organization?> CreateOrganizationAsync(int regionId, string name);

    Task<GetOrganizationsResponse> GetAllOrganizationAsync(GetOrganizationsRequest request);

    Task<GetOrganizationsResponse?> GetOrganizationAsync(GetOrganizationRequest request);

    Task RenameOrganizationAsync(long organizationId, string name);

    Task DeleteOrganizationAsync(long organizationId);
}