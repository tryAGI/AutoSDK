//HintName: G.Models.GetAnalyticsResponseErrorType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAnalyticsResponseErrorType2
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
    public static class GetAnalyticsResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsResponseErrorType2 value)
        {
            return value switch
            {
                GetAnalyticsResponseErrorType2.AuthorizationError => "authorization_error",
                GetAnalyticsResponseErrorType2.NotFound => "not_found",
                GetAnalyticsResponseErrorType2.NotImplemented => "not_implemented",
                GetAnalyticsResponseErrorType2.RateLimited => "rate_limited",
                GetAnalyticsResponseErrorType2.ServerError => "server_error",
                GetAnalyticsResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAnalyticsResponseErrorType2.AuthorizationError,
                "not_found" => GetAnalyticsResponseErrorType2.NotFound,
                "not_implemented" => GetAnalyticsResponseErrorType2.NotImplemented,
                "rate_limited" => GetAnalyticsResponseErrorType2.RateLimited,
                "server_error" => GetAnalyticsResponseErrorType2.ServerError,
                "validation_error" => GetAnalyticsResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}