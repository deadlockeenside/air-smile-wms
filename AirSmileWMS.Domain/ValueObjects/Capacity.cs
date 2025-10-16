using AirSmileWMS.Domain.Common;

namespace AirSmileWMS.Domain.ValueObjects;

public sealed record Capacity : BaseValueObject<byte>
{
    private Capacity(byte value) : base(value) { }

    protected override void Validate(byte value)
    {
        if (!BusinessRules.ValidCapacies.Contains(value))
            throw new InvalidDataException(ExceptionMessages.InvalidCapacity);
    }

    // Static fabric method
    public static Capacity Create(byte value) => new Capacity(value);
}
