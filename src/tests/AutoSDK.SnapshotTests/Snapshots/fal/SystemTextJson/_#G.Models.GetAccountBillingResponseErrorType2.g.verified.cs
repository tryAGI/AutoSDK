//HintName: G.Models.GetAccountBillingResponseErrorType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAccountBillingResponseErrorType2
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
    public static class GetAccountBillingResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAccountBillingResponseErrorType2 value)
        {
            return value switch
            {
                GetAccountBillingResponseErrorType2.AuthorizationError => "authorization_error",
                GetAccountBillingResponseErrorType2.NotFound => "not_found",
                GetAccountBillingResponseErrorType2.NotImplemented => "not_implemented",
                GetAccountBillingResponseErrorType2.RateLimited => "rate_limited",
                GetAccountBillingResponseErrorType2.ServerError => "server_error",
                GetAccountBillingResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAccountBillingResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAccountBillingResponseErrorType2.AuthorizationError,
                "not_found" => GetAccountBillingResponseErrorType2.NotFound,
                "not_implemented" => GetAccountBillingResponseErrorType2.NotImplemented,
                "rate_limited" => GetAccountBillingResponseErrorType2.RateLimited,
                "server_error" => GetAccountBillingResponseErrorType2.ServerError,
                "validation_error" => GetAccountBillingResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}