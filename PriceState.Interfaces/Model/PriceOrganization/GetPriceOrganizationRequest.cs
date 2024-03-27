using PriceState.Interfaces.Pagination;

namespace PriceState.Interfaces.Model.PriceOrganization;

public class GetPriceOrganizationRequest
{

    public DateTime Date { get; set; }

    public long ProductId { get; set; }

    public long OrganizationId { get; set; }
    public Page Page { get; set; } = new Page();
}