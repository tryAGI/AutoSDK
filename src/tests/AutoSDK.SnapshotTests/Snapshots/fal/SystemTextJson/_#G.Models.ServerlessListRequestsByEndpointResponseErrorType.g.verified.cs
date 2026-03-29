//HintName: G.Models.ServerlessListRequestsByEndpointResponseErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessListRequestsByEndpointResponseErrorType
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
    public static class ServerlessListRequestsByEndpointResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListRequestsByEndpointResponseErrorType value)
        {
            return value switch
            {
                ServerlessListRequestsByEndpointResponseErrorType.AuthorizationError => "authorization_error",
                ServerlessListRequestsByEndpointResponseErrorType.NotFound => "not_found",
                ServerlessListRequestsByEndpointResponseErrorType.NotImplemented => "not_implemented",
                ServerlessListRequestsByEndpointResponseErrorType.RateLimited => "rate_limited",
                ServerlessListRequestsByEndpointResponseErrorType.ServerError => "server_error",
                ServerlessListRequestsByEndpointResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListRequestsByEndpointResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListRequestsByEndpointResponseErrorType.AuthorizationError,
                "not_found" => ServerlessListRequestsByEndpointResponseErrorType.NotFound,
                "not_implemented" => ServerlessListRequestsByEndpointResponseErrorType.NotImplemented,
                "rate_limited" => ServerlessListRequestsByEndpointResponseErrorType.RateLimited,
                "server_error" => ServerlessListRequestsByEndpointResponseErrorType.ServerError,
                "validation_error" => ServerlessListRequestsByEndpointResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}