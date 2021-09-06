using API.DataStore.Domain;
using API.DataStore.Interface;
using API.Notifications;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace API.Handlers
{
    public class EmailHandler : INotificationHandler<ProductAddedNotification>
    {
        private readonly IDataStore _dataStore;
        private readonly IMapper _mapper;

        public EmailHandler(IDataStore dataStore, IMapper mapper)
        {
            _dataStore = dataStore;
            _mapper = mapper;
        }

        public async Task Handle(ProductAddedNotification notification, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Product>(notification.Product);
            await _dataStore.EventOccured(product, "Email sent");
            await Task.CompletedTask;
        }
    }
}
