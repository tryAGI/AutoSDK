//HintName: G.Models.GetAnalyticsResponseErrorType4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAnalyticsResponseErrorType4
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
    public static class GetAnalyticsResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsResponseErrorType4 value)
        {
            return value switch
            {
                GetAnalyticsResponseErrorType4.AuthorizationError => "authorization_error",
                GetAnalyticsResponseErrorType4.NotFound => "not_found",
                GetAnalyticsResponseErrorType4.NotImplemented => "not_implemented",
                GetAnalyticsResponseErrorType4.RateLimited => "rate_limited",
                GetAnalyticsResponseErrorType4.ServerError => "server_error",
                GetAnalyticsResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAnalyticsResponseErrorType4.AuthorizationError,
                "not_found" => GetAnalyticsResponseErrorType4.NotFound,
                "not_implemented" => GetAnalyticsResponseErrorType4.NotImplemented,
                "rate_limited" => GetAnalyticsResponseErrorType4.RateLimited,
                "server_error" => GetAnalyticsResponseErrorType4.ServerError,
                "validation_error" => GetAnalyticsResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}