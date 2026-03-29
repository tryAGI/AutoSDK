//HintName: G.Models.ServerlessFlushAppQueueResponseErrorType5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessFlushAppQueueResponseErrorType5
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
    public static class ServerlessFlushAppQueueResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessFlushAppQueueResponseErrorType5 value)
        {
            return value switch
            {
                ServerlessFlushAppQueueResponseErrorType5.AuthorizationError => "authorization_error",
                ServerlessFlushAppQueueResponseErrorType5.NotFound => "not_found",
                ServerlessFlushAppQueueResponseErrorType5.NotImplemented => "not_implemented",
                ServerlessFlushAppQueueResponseErrorType5.RateLimited => "rate_limited",
                ServerlessFlushAppQueueResponseErrorType5.ServerError => "server_error",
                ServerlessFlushAppQueueResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessFlushAppQueueResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessFlushAppQueueResponseErrorType5.AuthorizationError,
                "not_found" => ServerlessFlushAppQueueResponseErrorType5.NotFound,
                "not_implemented" => ServerlessFlushAppQueueResponseErrorType5.NotImplemented,
                "rate_limited" => ServerlessFlushAppQueueResponseErrorType5.RateLimited,
                "server_error" => ServerlessFlushAppQueueResponseErrorType5.ServerError,
                "validation_error" => ServerlessFlushAppQueueResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}