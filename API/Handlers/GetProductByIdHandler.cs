using API.DataStore.Domain;
using API.DataStore.Interface;
using API.Dtos;
using API.Queries;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace API.Handlers
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, ProductDto>
    {
        private readonly IDataStore _dataStore;
        private readonly IMapper _mapper;

        public GetProductByIdHandler(IDataStore sampleDataStore, IMapper mapper)
        {
            _dataStore = sampleDataStore;
            _mapper = mapper;
        }

        public async Task<ProductDto> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            Product product = await _dataStore.GetProductById(request.Id);
            ProductDto productDto = _mapper.Map<ProductDto>(product);
            return productDto;
        }

    }
}
