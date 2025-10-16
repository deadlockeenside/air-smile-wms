namespace AirSmileWMS.Domain.Common;

public static class BusinessRules
{
    public const byte MinTitleLength = 10;
    public const byte MaxTitleLength = byte.MaxValue;
    public const byte MinTextLength = 10;
    public const short MaxTextLength = 1000;

    public readonly static IReadOnlyList<byte> ValidCapacies = [1, 25, 50, 100];
}
