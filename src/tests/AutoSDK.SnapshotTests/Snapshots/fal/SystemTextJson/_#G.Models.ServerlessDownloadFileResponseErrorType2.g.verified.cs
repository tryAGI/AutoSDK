//HintName: G.Models.ServerlessDownloadFileResponseErrorType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessDownloadFileResponseErrorType2
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
    public static class ServerlessDownloadFileResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessDownloadFileResponseErrorType2 value)
        {
            return value switch
            {
                ServerlessDownloadFileResponseErrorType2.AuthorizationError => "authorization_error",
                ServerlessDownloadFileResponseErrorType2.NotFound => "not_found",
                ServerlessDownloadFileResponseErrorType2.NotImplemented => "not_implemented",
                ServerlessDownloadFileResponseErrorType2.RateLimited => "rate_limited",
                ServerlessDownloadFileResponseErrorType2.ServerError => "server_error",
                ServerlessDownloadFileResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessDownloadFileResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessDownloadFileResponseErrorType2.AuthorizationError,
                "not_found" => ServerlessDownloadFileResponseErrorType2.NotFound,
                "not_implemented" => ServerlessDownloadFileResponseErrorType2.NotImplemented,
                "rate_limited" => ServerlessDownloadFileResponseErrorType2.RateLimited,
                "server_error" => ServerlessDownloadFileResponseErrorType2.ServerError,
                "validation_error" => ServerlessDownloadFileResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}