//HintName: G.Models.ServerlessListRequestsByEndpointResponseErrorType3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessListRequestsByEndpointResponseErrorType3
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
    public static class ServerlessListRequestsByEndpointResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListRequestsByEndpointResponseErrorType3 value)
        {
            return value switch
            {
                ServerlessListRequestsByEndpointResponseErrorType3.AuthorizationError => "authorization_error",
                ServerlessListRequestsByEndpointResponseErrorType3.NotFound => "not_found",
                ServerlessListRequestsByEndpointResponseErrorType3.NotImplemented => "not_implemented",
                ServerlessListRequestsByEndpointResponseErrorType3.RateLimited => "rate_limited",
                ServerlessListRequestsByEndpointResponseErrorType3.ServerError => "server_error",
                ServerlessListRequestsByEndpointResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListRequestsByEndpointResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListRequestsByEndpointResponseErrorType3.AuthorizationError,
                "not_found" => ServerlessListRequestsByEndpointResponseErrorType3.NotFound,
                "not_implemented" => ServerlessListRequestsByEndpointResponseErrorType3.NotImplemented,
                "rate_limited" => ServerlessListRequestsByEndpointResponseErrorType3.RateLimited,
                "server_error" => ServerlessListRequestsByEndpointResponseErrorType3.ServerError,
                "validation_error" => ServerlessListRequestsByEndpointResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}