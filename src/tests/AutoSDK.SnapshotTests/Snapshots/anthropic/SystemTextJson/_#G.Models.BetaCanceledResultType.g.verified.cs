//HintName: G.Models.BetaCanceledResultType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: canceled
    /// </summary>
    public enum BetaCanceledResultType
    {
        /// <summary>
        /// 
        /// </summary>
        Canceled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCanceledResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCanceledResultType value)
        {
            return value switch
            {
                BetaCanceledResultType.Canceled => "canceled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCanceledResultType? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => BetaCanceledResultType.Canceled,
                _ => null,
            };
        }
    }
}