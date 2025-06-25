//HintName: G.Models.BetaGatewayTimeoutErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: timeout_error
    /// </summary>
    public enum BetaGatewayTimeoutErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        TimeoutError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaGatewayTimeoutErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGatewayTimeoutErrorType value)
        {
            return value switch
            {
                BetaGatewayTimeoutErrorType.TimeoutError => "timeout_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGatewayTimeoutErrorType? ToEnum(string value)
        {
            return value switch
            {
                "timeout_error" => BetaGatewayTimeoutErrorType.TimeoutError,
                _ => null,
            };
        }
    }
}