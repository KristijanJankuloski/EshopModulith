
namespace EshopModulith.Shared.DDD;
public abstract class Agregate<T> : Entity<T>, IAgregate<T>
{
    public readonly List<IDomainEvent> _domainEvents = new();
    public IReadOnlyList<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

    public void AddDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }

    public IDomainEvent[] ClearDomainEvents()
    {
        IDomainEvent[] dequeueEvents = _domainEvents.ToArray();
        _domainEvents.Clear();
        return dequeueEvents;
    }
}
