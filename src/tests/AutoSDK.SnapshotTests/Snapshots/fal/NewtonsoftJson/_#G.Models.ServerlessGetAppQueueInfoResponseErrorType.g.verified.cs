//HintName: G.Models.ServerlessGetAppQueueInfoResponseErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerlessGetAppQueueInfoResponseErrorType
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
    public static class ServerlessGetAppQueueInfoResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessGetAppQueueInfoResponseErrorType value)
        {
            return value switch
            {
                ServerlessGetAppQueueInfoResponseErrorType.AuthorizationError => "authorization_error",
                ServerlessGetAppQueueInfoResponseErrorType.NotFound => "not_found",
                ServerlessGetAppQueueInfoResponseErrorType.NotImplemented => "not_implemented",
                ServerlessGetAppQueueInfoResponseErrorType.RateLimited => "rate_limited",
                ServerlessGetAppQueueInfoResponseErrorType.ServerError => "server_error",
                ServerlessGetAppQueueInfoResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessGetAppQueueInfoResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessGetAppQueueInfoResponseErrorType.AuthorizationError,
                "not_found" => ServerlessGetAppQueueInfoResponseErrorType.NotFound,
                "not_implemented" => ServerlessGetAppQueueInfoResponseErrorType.NotImplemented,
                "rate_limited" => ServerlessGetAppQueueInfoResponseErrorType.RateLimited,
                "server_error" => ServerlessGetAppQueueInfoResponseErrorType.ServerError,
                "validation_error" => ServerlessGetAppQueueInfoResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}