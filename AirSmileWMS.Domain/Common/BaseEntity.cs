namespace AirSmileWMS.Domain.Common;

// This can easily be modified to be BaseEntity<T> and public T Id to support different key types.
public abstract class BaseEntity
{
    private int _id;

    // Using non-generic integer types for simplicity and to ease caching logic.
    public required int Id 
    {
        get => _id;
        init => _id = value != 0 ? value : throw new InvalidDataException(ExceptionMessages.EmptyId);
    }

    public sealed override bool Equals(object? obj) => obj is BaseEntity other && Id == other.Id && GetType() == other.GetType();
    public sealed override int GetHashCode() => Id.GetHashCode();
    public static bool operator ==(BaseEntity? a, BaseEntity? b) => Equals(a, b);
    public static bool operator !=(BaseEntity? a, BaseEntity? b) => !Equals(a, b);
}
