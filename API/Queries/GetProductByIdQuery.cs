using API.Dtos;
using MediatR;

namespace API.Queries
{
    public record GetProductByIdQuery(int Id) : IRequest<ProductDto>;

}
