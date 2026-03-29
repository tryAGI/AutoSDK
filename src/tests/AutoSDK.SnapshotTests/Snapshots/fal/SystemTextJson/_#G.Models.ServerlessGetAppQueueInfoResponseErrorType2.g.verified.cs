//HintName: G.Models.ServerlessGetAppQueueInfoResponseErrorType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessGetAppQueueInfoResponseErrorType2
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
    public static class ServerlessGetAppQueueInfoResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessGetAppQueueInfoResponseErrorType2 value)
        {
            return value switch
            {
                ServerlessGetAppQueueInfoResponseErrorType2.AuthorizationError => "authorization_error",
                ServerlessGetAppQueueInfoResponseErrorType2.NotFound => "not_found",
                ServerlessGetAppQueueInfoResponseErrorType2.NotImplemented => "not_implemented",
                ServerlessGetAppQueueInfoResponseErrorType2.RateLimited => "rate_limited",
                ServerlessGetAppQueueInfoResponseErrorType2.ServerError => "server_error",
                ServerlessGetAppQueueInfoResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessGetAppQueueInfoResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessGetAppQueueInfoResponseErrorType2.AuthorizationError,
                "not_found" => ServerlessGetAppQueueInfoResponseErrorType2.NotFound,
                "not_implemented" => ServerlessGetAppQueueInfoResponseErrorType2.NotImplemented,
                "rate_limited" => ServerlessGetAppQueueInfoResponseErrorType2.RateLimited,
                "server_error" => ServerlessGetAppQueueInfoResponseErrorType2.ServerError,
                "validation_error" => ServerlessGetAppQueueInfoResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}