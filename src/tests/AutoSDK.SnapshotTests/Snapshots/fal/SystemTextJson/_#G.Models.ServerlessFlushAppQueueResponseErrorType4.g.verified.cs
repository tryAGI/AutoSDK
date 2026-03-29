//HintName: G.Models.ServerlessFlushAppQueueResponseErrorType4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessFlushAppQueueResponseErrorType4
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
    public static class ServerlessFlushAppQueueResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessFlushAppQueueResponseErrorType4 value)
        {
            return value switch
            {
                ServerlessFlushAppQueueResponseErrorType4.AuthorizationError => "authorization_error",
                ServerlessFlushAppQueueResponseErrorType4.NotFound => "not_found",
                ServerlessFlushAppQueueResponseErrorType4.NotImplemented => "not_implemented",
                ServerlessFlushAppQueueResponseErrorType4.RateLimited => "rate_limited",
                ServerlessFlushAppQueueResponseErrorType4.ServerError => "server_error",
                ServerlessFlushAppQueueResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessFlushAppQueueResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessFlushAppQueueResponseErrorType4.AuthorizationError,
                "not_found" => ServerlessFlushAppQueueResponseErrorType4.NotFound,
                "not_implemented" => ServerlessFlushAppQueueResponseErrorType4.NotImplemented,
                "rate_limited" => ServerlessFlushAppQueueResponseErrorType4.RateLimited,
                "server_error" => ServerlessFlushAppQueueResponseErrorType4.ServerError,
                "validation_error" => ServerlessFlushAppQueueResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}