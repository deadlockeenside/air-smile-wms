using AirSmileWMS.Domain.Common;

namespace AirSmileWMS.Domain.ValueObjects;

public sealed record Text : BaseValueObject<string>
{
    private Text(string value) : base(value) { }

    protected override void Validate(string value)
    {
        if (value.Length < BusinessRules.MinTextLength)
            throw new InvalidDataException(ExceptionMessages.TooShortText);

        if (value.Length > BusinessRules.MaxTextLength)
            throw new InvalidDataException(ExceptionMessages.TooLongText);
    }

    // Static fabric method
    public static Text Create(string value) 
    {
        if (string.IsNullOrEmpty(value))
            throw new InvalidDataException(ExceptionMessages.EmptyText);

        return new Text(value.Trim());
    }
}
