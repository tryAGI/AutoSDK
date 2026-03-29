//HintName: G.Models.ServerlessListRequestsByEndpointResponseErrorType6.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessListRequestsByEndpointResponseErrorType6
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
    public static class ServerlessListRequestsByEndpointResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListRequestsByEndpointResponseErrorType6 value)
        {
            return value switch
            {
                ServerlessListRequestsByEndpointResponseErrorType6.AuthorizationError => "authorization_error",
                ServerlessListRequestsByEndpointResponseErrorType6.NotFound => "not_found",
                ServerlessListRequestsByEndpointResponseErrorType6.NotImplemented => "not_implemented",
                ServerlessListRequestsByEndpointResponseErrorType6.RateLimited => "rate_limited",
                ServerlessListRequestsByEndpointResponseErrorType6.ServerError => "server_error",
                ServerlessListRequestsByEndpointResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListRequestsByEndpointResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListRequestsByEndpointResponseErrorType6.AuthorizationError,
                "not_found" => ServerlessListRequestsByEndpointResponseErrorType6.NotFound,
                "not_implemented" => ServerlessListRequestsByEndpointResponseErrorType6.NotImplemented,
                "rate_limited" => ServerlessListRequestsByEndpointResponseErrorType6.RateLimited,
                "server_error" => ServerlessListRequestsByEndpointResponseErrorType6.ServerError,
                "validation_error" => ServerlessListRequestsByEndpointResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}