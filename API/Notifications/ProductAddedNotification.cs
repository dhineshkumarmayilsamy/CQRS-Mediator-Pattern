using API.DataStore.Domain;
using API.Dtos;
using MediatR;

namespace API.Notifications
{
    public record ProductAddedNotification(ProductDto Product) : INotification;
}
