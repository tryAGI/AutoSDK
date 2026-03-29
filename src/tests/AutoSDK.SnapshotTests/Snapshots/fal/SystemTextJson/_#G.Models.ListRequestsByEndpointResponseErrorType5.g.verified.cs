//HintName: G.Models.ListRequestsByEndpointResponseErrorType5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListRequestsByEndpointResponseErrorType5
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
    public static class ListRequestsByEndpointResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRequestsByEndpointResponseErrorType5 value)
        {
            return value switch
            {
                ListRequestsByEndpointResponseErrorType5.AuthorizationError => "authorization_error",
                ListRequestsByEndpointResponseErrorType5.NotFound => "not_found",
                ListRequestsByEndpointResponseErrorType5.NotImplemented => "not_implemented",
                ListRequestsByEndpointResponseErrorType5.RateLimited => "rate_limited",
                ListRequestsByEndpointResponseErrorType5.ServerError => "server_error",
                ListRequestsByEndpointResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRequestsByEndpointResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListRequestsByEndpointResponseErrorType5.AuthorizationError,
                "not_found" => ListRequestsByEndpointResponseErrorType5.NotFound,
                "not_implemented" => ListRequestsByEndpointResponseErrorType5.NotImplemented,
                "rate_limited" => ListRequestsByEndpointResponseErrorType5.RateLimited,
                "server_error" => ListRequestsByEndpointResponseErrorType5.ServerError,
                "validation_error" => ListRequestsByEndpointResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}