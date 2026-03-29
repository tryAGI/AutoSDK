//HintName: G.Models.ServerlessDownloadFileResponseErrorType3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessDownloadFileResponseErrorType3
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
    public static class ServerlessDownloadFileResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessDownloadFileResponseErrorType3 value)
        {
            return value switch
            {
                ServerlessDownloadFileResponseErrorType3.AuthorizationError => "authorization_error",
                ServerlessDownloadFileResponseErrorType3.NotFound => "not_found",
                ServerlessDownloadFileResponseErrorType3.NotImplemented => "not_implemented",
                ServerlessDownloadFileResponseErrorType3.RateLimited => "rate_limited",
                ServerlessDownloadFileResponseErrorType3.ServerError => "server_error",
                ServerlessDownloadFileResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessDownloadFileResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessDownloadFileResponseErrorType3.AuthorizationError,
                "not_found" => ServerlessDownloadFileResponseErrorType3.NotFound,
                "not_implemented" => ServerlessDownloadFileResponseErrorType3.NotImplemented,
                "rate_limited" => ServerlessDownloadFileResponseErrorType3.RateLimited,
                "server_error" => ServerlessDownloadFileResponseErrorType3.ServerError,
                "validation_error" => ServerlessDownloadFileResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}