//HintName: G.Models.SearchRequestsResponseErrorType4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SearchRequestsResponseErrorType4
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
    public static class SearchRequestsResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchRequestsResponseErrorType4 value)
        {
            return value switch
            {
                SearchRequestsResponseErrorType4.AuthorizationError => "authorization_error",
                SearchRequestsResponseErrorType4.NotFound => "not_found",
                SearchRequestsResponseErrorType4.NotImplemented => "not_implemented",
                SearchRequestsResponseErrorType4.RateLimited => "rate_limited",
                SearchRequestsResponseErrorType4.ServerError => "server_error",
                SearchRequestsResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchRequestsResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => SearchRequestsResponseErrorType4.AuthorizationError,
                "not_found" => SearchRequestsResponseErrorType4.NotFound,
                "not_implemented" => SearchRequestsResponseErrorType4.NotImplemented,
                "rate_limited" => SearchRequestsResponseErrorType4.RateLimited,
                "server_error" => SearchRequestsResponseErrorType4.ServerError,
                "validation_error" => SearchRequestsResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}