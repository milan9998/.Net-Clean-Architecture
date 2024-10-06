using MediatR;
using MongoDB.Entities;
using USP.Application.Common.Dto;
using USP.Application.Common.Mappers;

namespace USP.Application.Product.Queires;

public record GetOneProductQuery(string Id) : IRequest<ProductDetailsDto?>;

public class GetOneProductQueryHandler: IRequestHandler<GetOneProductQuery, ProductDetailsDto?>
{
    public async Task<ProductDetailsDto?> Handle(GetOneProductQuery request, CancellationToken cancellationToken) =>
        (await DB.Find<Domain.Entities.Product>().OneAsync(request.Id, cancellation: cancellationToken))?.ToDto();

    /*var entity = await DB.Find<Domain.Entities.Product>().OneAsync(request.Id, cancellation: cancellationToken);

    return entity?.ToDto();*/

}