//HintName: G.Models.EstimatePricingResponseErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EstimatePricingResponseErrorType
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
    public static class EstimatePricingResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimatePricingResponseErrorType value)
        {
            return value switch
            {
                EstimatePricingResponseErrorType.AuthorizationError => "authorization_error",
                EstimatePricingResponseErrorType.NotFound => "not_found",
                EstimatePricingResponseErrorType.NotImplemented => "not_implemented",
                EstimatePricingResponseErrorType.RateLimited => "rate_limited",
                EstimatePricingResponseErrorType.ServerError => "server_error",
                EstimatePricingResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimatePricingResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => EstimatePricingResponseErrorType.AuthorizationError,
                "not_found" => EstimatePricingResponseErrorType.NotFound,
                "not_implemented" => EstimatePricingResponseErrorType.NotImplemented,
                "rate_limited" => EstimatePricingResponseErrorType.RateLimited,
                "server_error" => EstimatePricingResponseErrorType.ServerError,
                "validation_error" => EstimatePricingResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}