//HintName: G.Models.ServerlessGetMetricsResponseErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessGetMetricsResponseErrorType
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
    public static class ServerlessGetMetricsResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessGetMetricsResponseErrorType value)
        {
            return value switch
            {
                ServerlessGetMetricsResponseErrorType.AuthorizationError => "authorization_error",
                ServerlessGetMetricsResponseErrorType.NotFound => "not_found",
                ServerlessGetMetricsResponseErrorType.NotImplemented => "not_implemented",
                ServerlessGetMetricsResponseErrorType.RateLimited => "rate_limited",
                ServerlessGetMetricsResponseErrorType.ServerError => "server_error",
                ServerlessGetMetricsResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessGetMetricsResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessGetMetricsResponseErrorType.AuthorizationError,
                "not_found" => ServerlessGetMetricsResponseErrorType.NotFound,
                "not_implemented" => ServerlessGetMetricsResponseErrorType.NotImplemented,
                "rate_limited" => ServerlessGetMetricsResponseErrorType.RateLimited,
                "server_error" => ServerlessGetMetricsResponseErrorType.ServerError,
                "validation_error" => ServerlessGetMetricsResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}