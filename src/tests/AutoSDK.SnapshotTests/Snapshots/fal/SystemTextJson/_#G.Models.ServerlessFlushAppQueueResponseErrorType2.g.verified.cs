//HintName: G.Models.ServerlessFlushAppQueueResponseErrorType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessFlushAppQueueResponseErrorType2
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
    public static class ServerlessFlushAppQueueResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessFlushAppQueueResponseErrorType2 value)
        {
            return value switch
            {
                ServerlessFlushAppQueueResponseErrorType2.AuthorizationError => "authorization_error",
                ServerlessFlushAppQueueResponseErrorType2.NotFound => "not_found",
                ServerlessFlushAppQueueResponseErrorType2.NotImplemented => "not_implemented",
                ServerlessFlushAppQueueResponseErrorType2.RateLimited => "rate_limited",
                ServerlessFlushAppQueueResponseErrorType2.ServerError => "server_error",
                ServerlessFlushAppQueueResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessFlushAppQueueResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessFlushAppQueueResponseErrorType2.AuthorizationError,
                "not_found" => ServerlessFlushAppQueueResponseErrorType2.NotFound,
                "not_implemented" => ServerlessFlushAppQueueResponseErrorType2.NotImplemented,
                "rate_limited" => ServerlessFlushAppQueueResponseErrorType2.RateLimited,
                "server_error" => ServerlessFlushAppQueueResponseErrorType2.ServerError,
                "validation_error" => ServerlessFlushAppQueueResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}