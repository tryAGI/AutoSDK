//HintName: G.Models.ServerlessLogsStreamResponseErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerlessLogsStreamResponseErrorType
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
    public static class ServerlessLogsStreamResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessLogsStreamResponseErrorType value)
        {
            return value switch
            {
                ServerlessLogsStreamResponseErrorType.AuthorizationError => "authorization_error",
                ServerlessLogsStreamResponseErrorType.NotFound => "not_found",
                ServerlessLogsStreamResponseErrorType.NotImplemented => "not_implemented",
                ServerlessLogsStreamResponseErrorType.RateLimited => "rate_limited",
                ServerlessLogsStreamResponseErrorType.ServerError => "server_error",
                ServerlessLogsStreamResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessLogsStreamResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessLogsStreamResponseErrorType.AuthorizationError,
                "not_found" => ServerlessLogsStreamResponseErrorType.NotFound,
                "not_implemented" => ServerlessLogsStreamResponseErrorType.NotImplemented,
                "rate_limited" => ServerlessLogsStreamResponseErrorType.RateLimited,
                "server_error" => ServerlessLogsStreamResponseErrorType.ServerError,
                "validation_error" => ServerlessLogsStreamResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}