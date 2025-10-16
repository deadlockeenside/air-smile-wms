using AirSmileWMS.Domain.Common;

namespace AirSmileWMS.Domain.ValueObjects;

public sealed record Image : BaseValueObject<byte[]>
{
    private Image(byte[] value) : base(value) { }

    protected override void Validate(byte[] value)
    {
        if (value is null)
            throw new InvalidDataException(ExceptionMessages.InvalidImage);
    }

    // Static fabric method
    public static Image Create(byte[] value) => new Image(value);
}
