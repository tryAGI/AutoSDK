//HintName: G.Models.ServerlessGetMetricsResponseErrorType3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessGetMetricsResponseErrorType3
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
    public static class ServerlessGetMetricsResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessGetMetricsResponseErrorType3 value)
        {
            return value switch
            {
                ServerlessGetMetricsResponseErrorType3.AuthorizationError => "authorization_error",
                ServerlessGetMetricsResponseErrorType3.NotFound => "not_found",
                ServerlessGetMetricsResponseErrorType3.NotImplemented => "not_implemented",
                ServerlessGetMetricsResponseErrorType3.RateLimited => "rate_limited",
                ServerlessGetMetricsResponseErrorType3.ServerError => "server_error",
                ServerlessGetMetricsResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessGetMetricsResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessGetMetricsResponseErrorType3.AuthorizationError,
                "not_found" => ServerlessGetMetricsResponseErrorType3.NotFound,
                "not_implemented" => ServerlessGetMetricsResponseErrorType3.NotImplemented,
                "rate_limited" => ServerlessGetMetricsResponseErrorType3.RateLimited,
                "server_error" => ServerlessGetMetricsResponseErrorType3.ServerError,
                "validation_error" => ServerlessGetMetricsResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}