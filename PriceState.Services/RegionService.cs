using Microsoft.EntityFrameworkCore;
using PriceState.Data;
using PriceState.Data.Models;
using PriceState.Interfaces;
using PriceState.Interfaces.Model;
using PriceState.Interfaces.Model.Region;
using PriceState.Interfaces.Pagination;

namespace PriceState.Services;

public class RegionService: IRegionService
{
	private readonly DataContext _db;

	public RegionService(DataContext db)
	{
		_db = db;
	}

	public async Task<Region> CreateRegionAsync( string name)
	{
		if (string.IsNullOrWhiteSpace(name))
			throw new PriceStateException("Incorrect region name!", EnumErrorCode.ArgumentIsIncorrect);

		if (await _db.Regions.AnyAsync(x => x.Name == name))
			throw new PriceStateException($"Region with name {name} is already exists!", EnumErrorCode.EntityIsAlreadyExists);


		var region = new Region
		{
			Name = name,

		};

		await _db.Regions.AddAsync(region);
		await _db.SaveChangesAsync();

		return region;
	}
	


	public async Task<GetRegionsResponse> GetAllRegionAsync(GetRegionsRequest request)
	{
		return await _db.Regions.GetPageAsync<GetRegionsResponse, Region, RegionModel>(request, region =>
			new RegionModel
			{
				Id = region.Id,
				Name = region.Name
			});
	}


	public async Task<GetRegionsResponse> GetRegionAsync(GetRegionRequest request)
	{
		var query = request.RegionId.HasValue
			? _db.Regions.Where(x => x.Id == request.RegionId)
			: _db.Regions.AsQueryable();

		var result = await query.GetPageAsync<GetRegionsResponse, Region, RegionModel>(request, x =>
			new RegionModel
			{
				Id = x.Id,
				Name = x.Name
			});

		return result;
	}
	

	public async Task RenameRegionAsync(int regionId, string name)
	{
		var region = await _db.Regions.FirstOrDefaultAsync(x => x.Id == regionId);
		if (region is null)
			throw new PriceStateException($"Region {regionId} is not exists!", EnumErrorCode.EntityIsNotFound);

		region.Name = name;
		await _db.SaveChangesAsync();
	}
	
	
	public async Task DeleteRegionAsync(int regionId)
	{
		_db.Regions.Remove(new Region {Id = regionId});
		await _db.SaveChangesAsync();
	}
	
}