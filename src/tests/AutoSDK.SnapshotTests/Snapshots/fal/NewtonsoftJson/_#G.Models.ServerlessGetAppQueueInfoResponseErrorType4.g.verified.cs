//HintName: G.Models.ServerlessGetAppQueueInfoResponseErrorType4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerlessGetAppQueueInfoResponseErrorType4
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
    public static class ServerlessGetAppQueueInfoResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessGetAppQueueInfoResponseErrorType4 value)
        {
            return value switch
            {
                ServerlessGetAppQueueInfoResponseErrorType4.AuthorizationError => "authorization_error",
                ServerlessGetAppQueueInfoResponseErrorType4.NotFound => "not_found",
                ServerlessGetAppQueueInfoResponseErrorType4.NotImplemented => "not_implemented",
                ServerlessGetAppQueueInfoResponseErrorType4.RateLimited => "rate_limited",
                ServerlessGetAppQueueInfoResponseErrorType4.ServerError => "server_error",
                ServerlessGetAppQueueInfoResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessGetAppQueueInfoResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessGetAppQueueInfoResponseErrorType4.AuthorizationError,
                "not_found" => ServerlessGetAppQueueInfoResponseErrorType4.NotFound,
                "not_implemented" => ServerlessGetAppQueueInfoResponseErrorType4.NotImplemented,
                "rate_limited" => ServerlessGetAppQueueInfoResponseErrorType4.RateLimited,
                "server_error" => ServerlessGetAppQueueInfoResponseErrorType4.ServerError,
                "validation_error" => ServerlessGetAppQueueInfoResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}