//HintName: G.Models.GetPricingResponseErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetPricingResponseErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="authorization_error")]
        AuthorizationError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_found")]
        NotFound,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_implemented")]
        NotImplemented,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rate_limited")]
        RateLimited,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="server_error")]
        ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="validation_error")]
        ValidationError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetPricingResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPricingResponseErrorType value)
        {
            return value switch
            {
                GetPricingResponseErrorType.AuthorizationError => "authorization_error",
                GetPricingResponseErrorType.NotFound => "not_found",
                GetPricingResponseErrorType.NotImplemented => "not_implemented",
                GetPricingResponseErrorType.RateLimited => "rate_limited",
                GetPricingResponseErrorType.ServerError => "server_error",
                GetPricingResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPricingResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetPricingResponseErrorType.AuthorizationError,
                "not_found" => GetPricingResponseErrorType.NotFound,
                "not_implemented" => GetPricingResponseErrorType.NotImplemented,
                "rate_limited" => GetPricingResponseErrorType.RateLimited,
                "server_error" => GetPricingResponseErrorType.ServerError,
                "validation_error" => GetPricingResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}