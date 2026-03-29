//HintName: G.Models.EstimatePricingResponseErrorType3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum EstimatePricingResponseErrorType3
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
    public static class EstimatePricingResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimatePricingResponseErrorType3 value)
        {
            return value switch
            {
                EstimatePricingResponseErrorType3.AuthorizationError => "authorization_error",
                EstimatePricingResponseErrorType3.NotFound => "not_found",
                EstimatePricingResponseErrorType3.NotImplemented => "not_implemented",
                EstimatePricingResponseErrorType3.RateLimited => "rate_limited",
                EstimatePricingResponseErrorType3.ServerError => "server_error",
                EstimatePricingResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimatePricingResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => EstimatePricingResponseErrorType3.AuthorizationError,
                "not_found" => EstimatePricingResponseErrorType3.NotFound,
                "not_implemented" => EstimatePricingResponseErrorType3.NotImplemented,
                "rate_limited" => EstimatePricingResponseErrorType3.RateLimited,
                "server_error" => EstimatePricingResponseErrorType3.ServerError,
                "validation_error" => EstimatePricingResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}