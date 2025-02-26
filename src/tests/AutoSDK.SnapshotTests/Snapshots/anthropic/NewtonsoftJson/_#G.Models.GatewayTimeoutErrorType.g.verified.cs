//HintName: G.Models.GatewayTimeoutErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: timeout_error
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GatewayTimeoutErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="timeout_error")]
        TimeoutError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GatewayTimeoutErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GatewayTimeoutErrorType value)
        {
            return value switch
            {
                GatewayTimeoutErrorType.TimeoutError => "timeout_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GatewayTimeoutErrorType? ToEnum(string value)
        {
            return value switch
            {
                "timeout_error" => GatewayTimeoutErrorType.TimeoutError,
                _ => null,
            };
        }
    }
}