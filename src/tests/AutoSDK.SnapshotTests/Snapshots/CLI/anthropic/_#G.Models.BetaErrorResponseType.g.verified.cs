//HintName: G.Models.BetaErrorResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: error
    /// </summary>
    public enum BetaErrorResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaErrorResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaErrorResponseType value)
        {
            return value switch
            {
                BetaErrorResponseType.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaErrorResponseType? ToEnum(string value)
        {
            return value switch
            {
                "error" => BetaErrorResponseType.Error,
                _ => null,
            };
        }
    }
}