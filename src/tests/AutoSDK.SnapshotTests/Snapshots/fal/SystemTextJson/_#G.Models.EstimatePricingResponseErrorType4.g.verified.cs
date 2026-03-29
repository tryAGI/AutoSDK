//HintName: G.Models.EstimatePricingResponseErrorType4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum EstimatePricingResponseErrorType4
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
    public static class EstimatePricingResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimatePricingResponseErrorType4 value)
        {
            return value switch
            {
                EstimatePricingResponseErrorType4.AuthorizationError => "authorization_error",
                EstimatePricingResponseErrorType4.NotFound => "not_found",
                EstimatePricingResponseErrorType4.NotImplemented => "not_implemented",
                EstimatePricingResponseErrorType4.RateLimited => "rate_limited",
                EstimatePricingResponseErrorType4.ServerError => "server_error",
                EstimatePricingResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimatePricingResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => EstimatePricingResponseErrorType4.AuthorizationError,
                "not_found" => EstimatePricingResponseErrorType4.NotFound,
                "not_implemented" => EstimatePricingResponseErrorType4.NotImplemented,
                "rate_limited" => EstimatePricingResponseErrorType4.RateLimited,
                "server_error" => EstimatePricingResponseErrorType4.ServerError,
                "validation_error" => EstimatePricingResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}