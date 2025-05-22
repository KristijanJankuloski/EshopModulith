namespace EshopModulith.Shared.DDD;

public interface IAgregate<T> : IAgregate, IEntity<T>
{
}

public interface IAgregate : IEntity
{
    IReadOnlyList<IDomainEvent> DomainEvents { get; }

    IDomainEvent[] ClearDomainEvents();
}
