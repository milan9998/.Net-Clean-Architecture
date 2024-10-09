using MediatR;
using MongoDB.Entities;
using USP.Application.Common.Dto;
using USP.Application.Common.Mappers;
using USP.Domain.Entities;
using USP.Domain.Enums;

namespace USP.Application.Product.Commands;

public record CreateProductCommand(ProductCreateDto Product): IRequest<ProductDetailsDto?>;
 
public class CreateProductHandler : IRequestHandler<CreateProductCommand, ProductDetailsDto?>
{
    public async Task<ProductDetailsDto?> Handle(CreateProductCommand request, CancellationToken cancellationToken) 
    {
        
        var user = new User
        {
            Email = "milan.pronic.212@singimail.rs",
            FirstName = "Milan2",
            LastName = "Pronic2 ",
        };
       await user.SaveAsync(cancellation: cancellationToken);

       var entity = request.Product.ToEntityFromCreateDto(user, new One<User>(user));
        
        await entity.SaveAsync(cancellation: cancellationToken);
        var dto = entity.ToDto();
        return dto;
    }
}