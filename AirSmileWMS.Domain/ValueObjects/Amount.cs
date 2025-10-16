using AirSmileWMS.Domain.Common;

namespace AirSmileWMS.Domain.ValueObjects;

public sealed record Amount : BaseValueObject<int>
{
    private Amount(int value) : base(value) { }

    protected override void Validate(int value)
    {
        if (value < 0)
            throw new InvalidDataException(ExceptionMessages.InvalidAmount);
    }

    // Static fabric method
    public static Amount Create(int value) => new Amount(value);
}
