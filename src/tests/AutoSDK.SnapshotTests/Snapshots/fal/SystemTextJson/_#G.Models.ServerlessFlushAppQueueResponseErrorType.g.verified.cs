//HintName: G.Models.ServerlessFlushAppQueueResponseErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessFlushAppQueueResponseErrorType
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
    public static class ServerlessFlushAppQueueResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessFlushAppQueueResponseErrorType value)
        {
            return value switch
            {
                ServerlessFlushAppQueueResponseErrorType.AuthorizationError => "authorization_error",
                ServerlessFlushAppQueueResponseErrorType.NotFound => "not_found",
                ServerlessFlushAppQueueResponseErrorType.NotImplemented => "not_implemented",
                ServerlessFlushAppQueueResponseErrorType.RateLimited => "rate_limited",
                ServerlessFlushAppQueueResponseErrorType.ServerError => "server_error",
                ServerlessFlushAppQueueResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessFlushAppQueueResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessFlushAppQueueResponseErrorType.AuthorizationError,
                "not_found" => ServerlessFlushAppQueueResponseErrorType.NotFound,
                "not_implemented" => ServerlessFlushAppQueueResponseErrorType.NotImplemented,
                "rate_limited" => ServerlessFlushAppQueueResponseErrorType.RateLimited,
                "server_error" => ServerlessFlushAppQueueResponseErrorType.ServerError,
                "validation_error" => ServerlessFlushAppQueueResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}