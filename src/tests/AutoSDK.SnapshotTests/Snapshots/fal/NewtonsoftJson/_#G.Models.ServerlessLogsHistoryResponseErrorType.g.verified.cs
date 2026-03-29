//HintName: G.Models.ServerlessLogsHistoryResponseErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerlessLogsHistoryResponseErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="authorization_error")]
        AuthorizationError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_found")]
        NotFound,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_implemented")]
        NotImplemented,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rate_limited")]
        RateLimited,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="server_error")]
        ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="validation_error")]
        ValidationError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerlessLogsHistoryResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessLogsHistoryResponseErrorType value)
        {
            return value switch
            {
                ServerlessLogsHistoryResponseErrorType.AuthorizationError => "authorization_error",
                ServerlessLogsHistoryResponseErrorType.NotFound => "not_found",
                ServerlessLogsHistoryResponseErrorType.NotImplemented => "not_implemented",
                ServerlessLogsHistoryResponseErrorType.RateLimited => "rate_limited",
                ServerlessLogsHistoryResponseErrorType.ServerError => "server_error",
                ServerlessLogsHistoryResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessLogsHistoryResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessLogsHistoryResponseErrorType.AuthorizationError,
                "not_found" => ServerlessLogsHistoryResponseErrorType.NotFound,
                "not_implemented" => ServerlessLogsHistoryResponseErrorType.NotImplemented,
                "rate_limited" => ServerlessLogsHistoryResponseErrorType.RateLimited,
                "server_error" => ServerlessLogsHistoryResponseErrorType.ServerError,
                "validation_error" => ServerlessLogsHistoryResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}