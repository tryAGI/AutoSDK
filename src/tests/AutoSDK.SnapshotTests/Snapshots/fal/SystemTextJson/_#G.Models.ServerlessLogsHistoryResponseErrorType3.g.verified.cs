//HintName: G.Models.ServerlessLogsHistoryResponseErrorType3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessLogsHistoryResponseErrorType3
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
    public static class ServerlessLogsHistoryResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessLogsHistoryResponseErrorType3 value)
        {
            return value switch
            {
                ServerlessLogsHistoryResponseErrorType3.AuthorizationError => "authorization_error",
                ServerlessLogsHistoryResponseErrorType3.NotFound => "not_found",
                ServerlessLogsHistoryResponseErrorType3.NotImplemented => "not_implemented",
                ServerlessLogsHistoryResponseErrorType3.RateLimited => "rate_limited",
                ServerlessLogsHistoryResponseErrorType3.ServerError => "server_error",
                ServerlessLogsHistoryResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessLogsHistoryResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessLogsHistoryResponseErrorType3.AuthorizationError,
                "not_found" => ServerlessLogsHistoryResponseErrorType3.NotFound,
                "not_implemented" => ServerlessLogsHistoryResponseErrorType3.NotImplemented,
                "rate_limited" => ServerlessLogsHistoryResponseErrorType3.RateLimited,
                "server_error" => ServerlessLogsHistoryResponseErrorType3.ServerError,
                "validation_error" => ServerlessLogsHistoryResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}