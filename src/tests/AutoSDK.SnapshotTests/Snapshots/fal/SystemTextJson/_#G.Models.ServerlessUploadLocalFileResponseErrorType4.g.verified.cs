//HintName: G.Models.ServerlessUploadLocalFileResponseErrorType4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessUploadLocalFileResponseErrorType4
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
    public static class ServerlessUploadLocalFileResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessUploadLocalFileResponseErrorType4 value)
        {
            return value switch
            {
                ServerlessUploadLocalFileResponseErrorType4.AuthorizationError => "authorization_error",
                ServerlessUploadLocalFileResponseErrorType4.NotFound => "not_found",
                ServerlessUploadLocalFileResponseErrorType4.NotImplemented => "not_implemented",
                ServerlessUploadLocalFileResponseErrorType4.RateLimited => "rate_limited",
                ServerlessUploadLocalFileResponseErrorType4.ServerError => "server_error",
                ServerlessUploadLocalFileResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessUploadLocalFileResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessUploadLocalFileResponseErrorType4.AuthorizationError,
                "not_found" => ServerlessUploadLocalFileResponseErrorType4.NotFound,
                "not_implemented" => ServerlessUploadLocalFileResponseErrorType4.NotImplemented,
                "rate_limited" => ServerlessUploadLocalFileResponseErrorType4.RateLimited,
                "server_error" => ServerlessUploadLocalFileResponseErrorType4.ServerError,
                "validation_error" => ServerlessUploadLocalFileResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}