//HintName: G.Models.ServerlessListRootResponseErrorType3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerlessListRootResponseErrorType3
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
    public static class ServerlessListRootResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListRootResponseErrorType3 value)
        {
            return value switch
            {
                ServerlessListRootResponseErrorType3.AuthorizationError => "authorization_error",
                ServerlessListRootResponseErrorType3.NotFound => "not_found",
                ServerlessListRootResponseErrorType3.NotImplemented => "not_implemented",
                ServerlessListRootResponseErrorType3.RateLimited => "rate_limited",
                ServerlessListRootResponseErrorType3.ServerError => "server_error",
                ServerlessListRootResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListRootResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListRootResponseErrorType3.AuthorizationError,
                "not_found" => ServerlessListRootResponseErrorType3.NotFound,
                "not_implemented" => ServerlessListRootResponseErrorType3.NotImplemented,
                "rate_limited" => ServerlessListRootResponseErrorType3.RateLimited,
                "server_error" => ServerlessListRootResponseErrorType3.ServerError,
                "validation_error" => ServerlessListRootResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}