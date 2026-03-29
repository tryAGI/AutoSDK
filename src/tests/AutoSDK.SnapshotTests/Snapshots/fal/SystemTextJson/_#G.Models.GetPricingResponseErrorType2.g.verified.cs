//HintName: G.Models.GetPricingResponseErrorType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetPricingResponseErrorType2
    {
        /// <summary>
        /// 
        /// </summary>
        AuthorizationError,
        /// <summary>
        /// 
        /// </summary>
        NotFound,
        /// <summary>
        /// 
        /// </summary>
        NotImplemented,
        /// <summary>
        /// 
        /// </summary>
        RateLimited,
        /// <summary>
        /// 
        /// </summary>
        ServerError,
        /// <summary>
        /// 
        /// </summary>
        ValidationError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetPricingResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPricingResponseErrorType2 value)
        {
            return value switch
            {
                GetPricingResponseErrorType2.AuthorizationError => "authorization_error",
                GetPricingResponseErrorType2.NotFound => "not_found",
                GetPricingResponseErrorType2.NotImplemented => "not_implemented",
                GetPricingResponseErrorType2.RateLimited => "rate_limited",
                GetPricingResponseErrorType2.ServerError => "server_error",
                GetPricingResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPricingResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetPricingResponseErrorType2.AuthorizationError,
                "not_found" => GetPricingResponseErrorType2.NotFound,
                "not_implemented" => GetPricingResponseErrorType2.NotImplemented,
                "rate_limited" => GetPricingResponseErrorType2.RateLimited,
                "server_error" => GetPricingResponseErrorType2.ServerError,
                "validation_error" => GetPricingResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}