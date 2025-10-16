namespace AirSmileWMS.Domain.Common;

public abstract record BaseValueObject<T> where T : notnull
{
    public static implicit operator T(BaseValueObject<T> obj) => obj is null ? throw new ArgumentNullException(nameof(obj)) : obj.Value;

    protected BaseValueObject(T value)
    {
        Validate(value);
        Value = value;
    }

    public T Value { get; private init; }

    protected abstract void Validate(T value);

    public sealed override string ToString() => Value?.ToString() ?? string.Empty;
}
