using MediatR;
using MongoDB.Entities;
using USP.Application.Common.Dto;
using USP.Application.Common.Mappers;

namespace USP.Application.Product.Commands;

public record CreateProductCommand(ProductCreateDto Product): IRequest<ProductDetailsDto?>;
 
public class CreateProductHandler : IRequestHandler<CreateProductCommand, ProductDetailsDto?>
{
    public async Task<ProductDetailsDto?> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var entity = request.Product.ToEntityFromCreateDto();
        
        await entity.SaveAsync(cancellation: cancellationToken);
        var dto = entity.ToDto();
        return dto;
    }
}