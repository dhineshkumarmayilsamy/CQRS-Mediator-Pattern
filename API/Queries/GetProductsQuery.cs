using API.Dtos;
using MediatR;
using System.Collections.Generic;

namespace API.Queries
{
    public record GetProductsQuery() : IRequest<IEnumerable<ProductDto>>;

}
