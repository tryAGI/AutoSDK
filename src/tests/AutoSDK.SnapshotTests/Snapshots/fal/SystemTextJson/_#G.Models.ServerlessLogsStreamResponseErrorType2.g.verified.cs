//HintName: G.Models.ServerlessLogsStreamResponseErrorType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessLogsStreamResponseErrorType2
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
    public static class ServerlessLogsStreamResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessLogsStreamResponseErrorType2 value)
        {
            return value switch
            {
                ServerlessLogsStreamResponseErrorType2.AuthorizationError => "authorization_error",
                ServerlessLogsStreamResponseErrorType2.NotFound => "not_found",
                ServerlessLogsStreamResponseErrorType2.NotImplemented => "not_implemented",
                ServerlessLogsStreamResponseErrorType2.RateLimited => "rate_limited",
                ServerlessLogsStreamResponseErrorType2.ServerError => "server_error",
                ServerlessLogsStreamResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessLogsStreamResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessLogsStreamResponseErrorType2.AuthorizationError,
                "not_found" => ServerlessLogsStreamResponseErrorType2.NotFound,
                "not_implemented" => ServerlessLogsStreamResponseErrorType2.NotImplemented,
                "rate_limited" => ServerlessLogsStreamResponseErrorType2.RateLimited,
                "server_error" => ServerlessLogsStreamResponseErrorType2.ServerError,
                "validation_error" => ServerlessLogsStreamResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}