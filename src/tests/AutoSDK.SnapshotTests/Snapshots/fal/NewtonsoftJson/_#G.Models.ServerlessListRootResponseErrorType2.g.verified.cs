//HintName: G.Models.ServerlessListRootResponseErrorType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerlessListRootResponseErrorType2
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
    public static class ServerlessListRootResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListRootResponseErrorType2 value)
        {
            return value switch
            {
                ServerlessListRootResponseErrorType2.AuthorizationError => "authorization_error",
                ServerlessListRootResponseErrorType2.NotFound => "not_found",
                ServerlessListRootResponseErrorType2.NotImplemented => "not_implemented",
                ServerlessListRootResponseErrorType2.RateLimited => "rate_limited",
                ServerlessListRootResponseErrorType2.ServerError => "server_error",
                ServerlessListRootResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListRootResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListRootResponseErrorType2.AuthorizationError,
                "not_found" => ServerlessListRootResponseErrorType2.NotFound,
                "not_implemented" => ServerlessListRootResponseErrorType2.NotImplemented,
                "rate_limited" => ServerlessListRootResponseErrorType2.RateLimited,
                "server_error" => ServerlessListRootResponseErrorType2.ServerError,
                "validation_error" => ServerlessListRootResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}