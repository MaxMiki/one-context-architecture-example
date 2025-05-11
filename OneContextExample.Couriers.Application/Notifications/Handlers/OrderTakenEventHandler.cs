using JetBrains.Annotations;
using Mediator;
using OneContextExample.Couriers.Application.Services;
using OneContextExample.Couriers.Domain.Events;

namespace OneContextExample.Couriers.Application.Notifications.Handlers;

[UsedImplicitly]
public class OrderTakenEventHandler(IOrdersAccessor ordersAccessor) : INotificationHandler<OrderTakenEvent>
{
    public async ValueTask Handle(OrderTakenEvent notification, CancellationToken cancellationToken)
    {
        await ordersAccessor.TakeOrder(notification.OrderId, cancellationToken);
    }
}