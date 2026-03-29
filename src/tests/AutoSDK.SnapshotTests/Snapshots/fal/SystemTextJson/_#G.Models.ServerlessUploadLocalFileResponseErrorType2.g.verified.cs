//HintName: G.Models.ServerlessUploadLocalFileResponseErrorType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessUploadLocalFileResponseErrorType2
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
    public static class ServerlessUploadLocalFileResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessUploadLocalFileResponseErrorType2 value)
        {
            return value switch
            {
                ServerlessUploadLocalFileResponseErrorType2.AuthorizationError => "authorization_error",
                ServerlessUploadLocalFileResponseErrorType2.NotFound => "not_found",
                ServerlessUploadLocalFileResponseErrorType2.NotImplemented => "not_implemented",
                ServerlessUploadLocalFileResponseErrorType2.RateLimited => "rate_limited",
                ServerlessUploadLocalFileResponseErrorType2.ServerError => "server_error",
                ServerlessUploadLocalFileResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessUploadLocalFileResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessUploadLocalFileResponseErrorType2.AuthorizationError,
                "not_found" => ServerlessUploadLocalFileResponseErrorType2.NotFound,
                "not_implemented" => ServerlessUploadLocalFileResponseErrorType2.NotImplemented,
                "rate_limited" => ServerlessUploadLocalFileResponseErrorType2.RateLimited,
                "server_error" => ServerlessUploadLocalFileResponseErrorType2.ServerError,
                "validation_error" => ServerlessUploadLocalFileResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}