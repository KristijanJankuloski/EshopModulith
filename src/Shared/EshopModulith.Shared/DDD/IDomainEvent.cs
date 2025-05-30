﻿using MediatR;

namespace EshopModulith.Shared.DDD;
public interface IDomainEvent : INotification
{
    Guid EventId => Guid.NewGuid();

    public DateTime OccuredOn => DateTime.Now;

    public string EventType => GetType().AssemblyQualifiedName!;
}
