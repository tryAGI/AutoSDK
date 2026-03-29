//HintName: G.Models.ServerlessListDirectoryResponseErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerlessListDirectoryResponseErrorType
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
    public static class ServerlessListDirectoryResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListDirectoryResponseErrorType value)
        {
            return value switch
            {
                ServerlessListDirectoryResponseErrorType.AuthorizationError => "authorization_error",
                ServerlessListDirectoryResponseErrorType.NotFound => "not_found",
                ServerlessListDirectoryResponseErrorType.NotImplemented => "not_implemented",
                ServerlessListDirectoryResponseErrorType.RateLimited => "rate_limited",
                ServerlessListDirectoryResponseErrorType.ServerError => "server_error",
                ServerlessListDirectoryResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListDirectoryResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListDirectoryResponseErrorType.AuthorizationError,
                "not_found" => ServerlessListDirectoryResponseErrorType.NotFound,
                "not_implemented" => ServerlessListDirectoryResponseErrorType.NotImplemented,
                "rate_limited" => ServerlessListDirectoryResponseErrorType.RateLimited,
                "server_error" => ServerlessListDirectoryResponseErrorType.ServerError,
                "validation_error" => ServerlessListDirectoryResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}