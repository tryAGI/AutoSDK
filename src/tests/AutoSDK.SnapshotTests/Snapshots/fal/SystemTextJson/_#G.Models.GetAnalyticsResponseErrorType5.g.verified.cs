//HintName: G.Models.GetAnalyticsResponseErrorType5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAnalyticsResponseErrorType5
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
    public static class GetAnalyticsResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsResponseErrorType5 value)
        {
            return value switch
            {
                GetAnalyticsResponseErrorType5.AuthorizationError => "authorization_error",
                GetAnalyticsResponseErrorType5.NotFound => "not_found",
                GetAnalyticsResponseErrorType5.NotImplemented => "not_implemented",
                GetAnalyticsResponseErrorType5.RateLimited => "rate_limited",
                GetAnalyticsResponseErrorType5.ServerError => "server_error",
                GetAnalyticsResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAnalyticsResponseErrorType5.AuthorizationError,
                "not_found" => GetAnalyticsResponseErrorType5.NotFound,
                "not_implemented" => GetAnalyticsResponseErrorType5.NotImplemented,
                "rate_limited" => GetAnalyticsResponseErrorType5.RateLimited,
                "server_error" => GetAnalyticsResponseErrorType5.ServerError,
                "validation_error" => GetAnalyticsResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}