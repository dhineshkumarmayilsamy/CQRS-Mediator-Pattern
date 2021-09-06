using API.Dtos;
using MediatR;

namespace API.Commands
{
    public record AddProductCommand(ProductDto Product) : IRequest<ProductDto>;

}
