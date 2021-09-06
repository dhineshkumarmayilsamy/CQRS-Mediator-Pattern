using API.Commands;
using API.DataStore.Domain;
using API.DataStore.Interface;
using API.Dtos;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace API.Handlers
{
    public class AddProductHandler : IRequestHandler<AddProductCommand, ProductDto>
    {
        private readonly IDataStore _dataStore;
        private readonly IMapper _mapper;

        public AddProductHandler(IDataStore sampleDataStore, IMapper mapper)
        {
            _dataStore = sampleDataStore;
            _mapper = mapper;
        }

        public async Task<ProductDto> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            Product product = _mapper.Map<Product>(request.Product);
            await _dataStore.AddProduct(product);

            return request.Product;
        }
    }
}
