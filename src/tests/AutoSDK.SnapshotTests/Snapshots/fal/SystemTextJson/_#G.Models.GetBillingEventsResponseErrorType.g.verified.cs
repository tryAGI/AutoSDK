//HintName: G.Models.GetBillingEventsResponseErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetBillingEventsResponseErrorType
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
    public static class GetBillingEventsResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBillingEventsResponseErrorType value)
        {
            return value switch
            {
                GetBillingEventsResponseErrorType.AuthorizationError => "authorization_error",
                GetBillingEventsResponseErrorType.NotFound => "not_found",
                GetBillingEventsResponseErrorType.NotImplemented => "not_implemented",
                GetBillingEventsResponseErrorType.RateLimited => "rate_limited",
                GetBillingEventsResponseErrorType.ServerError => "server_error",
                GetBillingEventsResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBillingEventsResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetBillingEventsResponseErrorType.AuthorizationError,
                "not_found" => GetBillingEventsResponseErrorType.NotFound,
                "not_implemented" => GetBillingEventsResponseErrorType.NotImplemented,
                "rate_limited" => GetBillingEventsResponseErrorType.RateLimited,
                "server_error" => GetBillingEventsResponseErrorType.ServerError,
                "validation_error" => GetBillingEventsResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}