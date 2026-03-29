//HintName: G.Models.ServerlessListRequestsByEndpointResponseErrorType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessListRequestsByEndpointResponseErrorType2
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
    public static class ServerlessListRequestsByEndpointResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListRequestsByEndpointResponseErrorType2 value)
        {
            return value switch
            {
                ServerlessListRequestsByEndpointResponseErrorType2.AuthorizationError => "authorization_error",
                ServerlessListRequestsByEndpointResponseErrorType2.NotFound => "not_found",
                ServerlessListRequestsByEndpointResponseErrorType2.NotImplemented => "not_implemented",
                ServerlessListRequestsByEndpointResponseErrorType2.RateLimited => "rate_limited",
                ServerlessListRequestsByEndpointResponseErrorType2.ServerError => "server_error",
                ServerlessListRequestsByEndpointResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListRequestsByEndpointResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListRequestsByEndpointResponseErrorType2.AuthorizationError,
                "not_found" => ServerlessListRequestsByEndpointResponseErrorType2.NotFound,
                "not_implemented" => ServerlessListRequestsByEndpointResponseErrorType2.NotImplemented,
                "rate_limited" => ServerlessListRequestsByEndpointResponseErrorType2.RateLimited,
                "server_error" => ServerlessListRequestsByEndpointResponseErrorType2.ServerError,
                "validation_error" => ServerlessListRequestsByEndpointResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}