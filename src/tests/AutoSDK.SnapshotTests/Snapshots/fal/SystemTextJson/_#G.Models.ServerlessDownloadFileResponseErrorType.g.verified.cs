//HintName: G.Models.ServerlessDownloadFileResponseErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessDownloadFileResponseErrorType
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
    public static class ServerlessDownloadFileResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessDownloadFileResponseErrorType value)
        {
            return value switch
            {
                ServerlessDownloadFileResponseErrorType.AuthorizationError => "authorization_error",
                ServerlessDownloadFileResponseErrorType.NotFound => "not_found",
                ServerlessDownloadFileResponseErrorType.NotImplemented => "not_implemented",
                ServerlessDownloadFileResponseErrorType.RateLimited => "rate_limited",
                ServerlessDownloadFileResponseErrorType.ServerError => "server_error",
                ServerlessDownloadFileResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessDownloadFileResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessDownloadFileResponseErrorType.AuthorizationError,
                "not_found" => ServerlessDownloadFileResponseErrorType.NotFound,
                "not_implemented" => ServerlessDownloadFileResponseErrorType.NotImplemented,
                "rate_limited" => ServerlessDownloadFileResponseErrorType.RateLimited,
                "server_error" => ServerlessDownloadFileResponseErrorType.ServerError,
                "validation_error" => ServerlessDownloadFileResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}