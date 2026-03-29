//HintName: G.Models.GetBillingEventsResponseErrorType4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetBillingEventsResponseErrorType4
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
    public static class GetBillingEventsResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBillingEventsResponseErrorType4 value)
        {
            return value switch
            {
                GetBillingEventsResponseErrorType4.AuthorizationError => "authorization_error",
                GetBillingEventsResponseErrorType4.NotFound => "not_found",
                GetBillingEventsResponseErrorType4.NotImplemented => "not_implemented",
                GetBillingEventsResponseErrorType4.RateLimited => "rate_limited",
                GetBillingEventsResponseErrorType4.ServerError => "server_error",
                GetBillingEventsResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBillingEventsResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetBillingEventsResponseErrorType4.AuthorizationError,
                "not_found" => GetBillingEventsResponseErrorType4.NotFound,
                "not_implemented" => GetBillingEventsResponseErrorType4.NotImplemented,
                "rate_limited" => GetBillingEventsResponseErrorType4.RateLimited,
                "server_error" => GetBillingEventsResponseErrorType4.ServerError,
                "validation_error" => GetBillingEventsResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}