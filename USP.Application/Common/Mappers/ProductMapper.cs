using MongoDB.Entities;
using Riok.Mapperly.Abstractions;
using USP.Application.Common.Dto;
using USP.Domain.Entities;
using USP.Domain.Enums;

namespace USP.Application.Common.Mappers;

[Mapper]
public static partial class ProductMapper
{
    public static partial ProductDetailsDto ToDto(this Domain.Entities.Product product);

    public static Domain.Entities.Product ToEntityFromCreateDto(this ProductCreateDto product,User user,One<User> referencedOneToOneUser)
    {
        var entity = new Domain.Entities.Product
        {
            Name = product.Name,
            Description = product.Description,
            Price = product.Price,
            Category = Category.FromValue(product.Category),
            User = user,
            ReferencedOneToOneUser = referencedOneToOneUser
            
        };
        return entity;
    }
}