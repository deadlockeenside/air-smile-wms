using AirSmileWMS.Domain.Common;

namespace AirSmileWMS.Domain.ValueObjects;

public sealed record Title : BaseValueObject<string>
{
    private Title(string value) : base(value) { }

    protected override void Validate(string value)
    {
        if (value.Length < BusinessRules.MinTitleLength)
            throw new InvalidDataException(ExceptionMessages.TooShortTitle);

        if (value.Length > BusinessRules.MaxTitleLength)
            throw new InvalidDataException(ExceptionMessages.TooLongTitle);

        // Local Easter egg for the WMS users (18+)
        if (value.Equals("ДБ дешевле", StringComparison.OrdinalIgnoreCase))
            throw new InvalidDataException("Какой долбаеб вбил в наименование \"ДБ дешевле\"?");
    }

    // Static fabric method
    public static Title Create(string value) 
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new InvalidDataException(ExceptionMessages.EmptyTitle);

        return new Title(value.Trim());
    }
}
