//HintName: G.Models.ServerlessListRequestsByEndpointResponseErrorType4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerlessListRequestsByEndpointResponseErrorType4
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
    public static class ServerlessListRequestsByEndpointResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListRequestsByEndpointResponseErrorType4 value)
        {
            return value switch
            {
                ServerlessListRequestsByEndpointResponseErrorType4.AuthorizationError => "authorization_error",
                ServerlessListRequestsByEndpointResponseErrorType4.NotFound => "not_found",
                ServerlessListRequestsByEndpointResponseErrorType4.NotImplemented => "not_implemented",
                ServerlessListRequestsByEndpointResponseErrorType4.RateLimited => "rate_limited",
                ServerlessListRequestsByEndpointResponseErrorType4.ServerError => "server_error",
                ServerlessListRequestsByEndpointResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListRequestsByEndpointResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListRequestsByEndpointResponseErrorType4.AuthorizationError,
                "not_found" => ServerlessListRequestsByEndpointResponseErrorType4.NotFound,
                "not_implemented" => ServerlessListRequestsByEndpointResponseErrorType4.NotImplemented,
                "rate_limited" => ServerlessListRequestsByEndpointResponseErrorType4.RateLimited,
                "server_error" => ServerlessListRequestsByEndpointResponseErrorType4.ServerError,
                "validation_error" => ServerlessListRequestsByEndpointResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}