//HintName: G.Models.ListRequestsByEndpointResponseErrorType4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListRequestsByEndpointResponseErrorType4
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
    public static class ListRequestsByEndpointResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRequestsByEndpointResponseErrorType4 value)
        {
            return value switch
            {
                ListRequestsByEndpointResponseErrorType4.AuthorizationError => "authorization_error",
                ListRequestsByEndpointResponseErrorType4.NotFound => "not_found",
                ListRequestsByEndpointResponseErrorType4.NotImplemented => "not_implemented",
                ListRequestsByEndpointResponseErrorType4.RateLimited => "rate_limited",
                ListRequestsByEndpointResponseErrorType4.ServerError => "server_error",
                ListRequestsByEndpointResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRequestsByEndpointResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListRequestsByEndpointResponseErrorType4.AuthorizationError,
                "not_found" => ListRequestsByEndpointResponseErrorType4.NotFound,
                "not_implemented" => ListRequestsByEndpointResponseErrorType4.NotImplemented,
                "rate_limited" => ListRequestsByEndpointResponseErrorType4.RateLimited,
                "server_error" => ListRequestsByEndpointResponseErrorType4.ServerError,
                "validation_error" => ListRequestsByEndpointResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}