//HintName: G.Models.BetaAPIErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: api_error
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaAPIErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="api_error")]
        ApiError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAPIErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAPIErrorType value)
        {
            return value switch
            {
                BetaAPIErrorType.ApiError => "api_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAPIErrorType? ToEnum(string value)
        {
            return value switch
            {
                "api_error" => BetaAPIErrorType.ApiError,
                _ => null,
            };
        }
    }
}