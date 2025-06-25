//HintName: G.Models.BetaNotFoundErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: not_found_error
    /// </summary>
    public enum BetaNotFoundErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        NotFoundError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaNotFoundErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaNotFoundErrorType value)
        {
            return value switch
            {
                BetaNotFoundErrorType.NotFoundError => "not_found_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaNotFoundErrorType? ToEnum(string value)
        {
            return value switch
            {
                "not_found_error" => BetaNotFoundErrorType.NotFoundError,
                _ => null,
            };
        }
    }
}