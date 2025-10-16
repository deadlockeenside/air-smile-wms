namespace AirSmileWMS.Domain.Common;

// This can easily be modified to be BaseEntity<T> and public T Id to support different key types.
public class BaseEntity
{
    // Using non-generic integer types for simplicity and to ease caching logic.
    public required int Id { get; init; }
}
