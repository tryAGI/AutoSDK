//HintName: G.Models.ServerlessUploadFromUrlResponseErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessUploadFromUrlResponseErrorType
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
    public static class ServerlessUploadFromUrlResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessUploadFromUrlResponseErrorType value)
        {
            return value switch
            {
                ServerlessUploadFromUrlResponseErrorType.AuthorizationError => "authorization_error",
                ServerlessUploadFromUrlResponseErrorType.NotFound => "not_found",
                ServerlessUploadFromUrlResponseErrorType.NotImplemented => "not_implemented",
                ServerlessUploadFromUrlResponseErrorType.RateLimited => "rate_limited",
                ServerlessUploadFromUrlResponseErrorType.ServerError => "server_error",
                ServerlessUploadFromUrlResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessUploadFromUrlResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessUploadFromUrlResponseErrorType.AuthorizationError,
                "not_found" => ServerlessUploadFromUrlResponseErrorType.NotFound,
                "not_implemented" => ServerlessUploadFromUrlResponseErrorType.NotImplemented,
                "rate_limited" => ServerlessUploadFromUrlResponseErrorType.RateLimited,
                "server_error" => ServerlessUploadFromUrlResponseErrorType.ServerError,
                "validation_error" => ServerlessUploadFromUrlResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}