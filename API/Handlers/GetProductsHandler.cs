using API.DataStore.Interface;
using API.Dtos;
using API.Queries;
using AutoMapper;
using MediatR;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace API.Handlers
{
    public class GetProductsHandler : IRequestHandler<GetProductsQuery, IEnumerable<ProductDto>>
    {
        private readonly IDataStore _dataStore;
        private readonly IMapper _mapper;
        public GetProductsHandler(IDataStore sampleDataStore, IMapper mapper)
        {
            _dataStore = sampleDataStore;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDto>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            IEnumerable products = await _dataStore.GetAllProducts();
            return _mapper.Map<List<ProductDto>>(products);
        }
    }
}
