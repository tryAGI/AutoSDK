//HintName: G.Models.ListRequestsByEndpointResponseErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListRequestsByEndpointResponseErrorType
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
    public static class ListRequestsByEndpointResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRequestsByEndpointResponseErrorType value)
        {
            return value switch
            {
                ListRequestsByEndpointResponseErrorType.AuthorizationError => "authorization_error",
                ListRequestsByEndpointResponseErrorType.NotFound => "not_found",
                ListRequestsByEndpointResponseErrorType.NotImplemented => "not_implemented",
                ListRequestsByEndpointResponseErrorType.RateLimited => "rate_limited",
                ListRequestsByEndpointResponseErrorType.ServerError => "server_error",
                ListRequestsByEndpointResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRequestsByEndpointResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListRequestsByEndpointResponseErrorType.AuthorizationError,
                "not_found" => ListRequestsByEndpointResponseErrorType.NotFound,
                "not_implemented" => ListRequestsByEndpointResponseErrorType.NotImplemented,
                "rate_limited" => ListRequestsByEndpointResponseErrorType.RateLimited,
                "server_error" => ListRequestsByEndpointResponseErrorType.ServerError,
                "validation_error" => ListRequestsByEndpointResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}