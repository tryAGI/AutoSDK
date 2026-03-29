//HintName: G.Models.ServerlessFlushAppQueueResponseErrorType6.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerlessFlushAppQueueResponseErrorType6
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
    public static class ServerlessFlushAppQueueResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessFlushAppQueueResponseErrorType6 value)
        {
            return value switch
            {
                ServerlessFlushAppQueueResponseErrorType6.AuthorizationError => "authorization_error",
                ServerlessFlushAppQueueResponseErrorType6.NotFound => "not_found",
                ServerlessFlushAppQueueResponseErrorType6.NotImplemented => "not_implemented",
                ServerlessFlushAppQueueResponseErrorType6.RateLimited => "rate_limited",
                ServerlessFlushAppQueueResponseErrorType6.ServerError => "server_error",
                ServerlessFlushAppQueueResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessFlushAppQueueResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessFlushAppQueueResponseErrorType6.AuthorizationError,
                "not_found" => ServerlessFlushAppQueueResponseErrorType6.NotFound,
                "not_implemented" => ServerlessFlushAppQueueResponseErrorType6.NotImplemented,
                "rate_limited" => ServerlessFlushAppQueueResponseErrorType6.RateLimited,
                "server_error" => ServerlessFlushAppQueueResponseErrorType6.ServerError,
                "validation_error" => ServerlessFlushAppQueueResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}