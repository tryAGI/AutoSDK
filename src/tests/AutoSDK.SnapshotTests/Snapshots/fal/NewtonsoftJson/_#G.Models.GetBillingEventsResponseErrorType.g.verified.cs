//HintName: G.Models.GetBillingEventsResponseErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetBillingEventsResponseErrorType
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
    public static class GetBillingEventsResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBillingEventsResponseErrorType value)
        {
            return value switch
            {
                GetBillingEventsResponseErrorType.AuthorizationError => "authorization_error",
                GetBillingEventsResponseErrorType.NotFound => "not_found",
                GetBillingEventsResponseErrorType.NotImplemented => "not_implemented",
                GetBillingEventsResponseErrorType.RateLimited => "rate_limited",
                GetBillingEventsResponseErrorType.ServerError => "server_error",
                GetBillingEventsResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBillingEventsResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetBillingEventsResponseErrorType.AuthorizationError,
                "not_found" => GetBillingEventsResponseErrorType.NotFound,
                "not_implemented" => GetBillingEventsResponseErrorType.NotImplemented,
                "rate_limited" => GetBillingEventsResponseErrorType.RateLimited,
                "server_error" => GetBillingEventsResponseErrorType.ServerError,
                "validation_error" => GetBillingEventsResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}