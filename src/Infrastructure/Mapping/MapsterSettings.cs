﻿using FSH.WebApi.Application.Identity.Roles;
using FSH.WebApi.Infrastructure.Identity;
using Mapster;

namespace FSH.WebApi.Infrastructure.Mapping;

public class MapsterSettings
{
    public static void Configure()
    {
        // here we will define the type conversion / Custom-mapping
        // More details at https://github.com/MapsterMapper/Mapster/wiki/Custom-mapping

        // This is used in UserService.GetPermissionsAsync
        TypeAdapterConfig<ApplicationRoleClaim, PermissionDto>.NewConfig().Map(dest => dest.Permission, src => src.ClaimValue);

        // This one is actually not necessary as it's mapped by convention
        // TypeAdapterConfig<Product, ProductDto>.NewConfig().Map(dest => dest.BrandName, src => src.Brand.Name);
    }
}