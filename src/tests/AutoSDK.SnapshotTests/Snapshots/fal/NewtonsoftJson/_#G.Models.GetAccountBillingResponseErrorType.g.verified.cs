//HintName: G.Models.GetAccountBillingResponseErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAccountBillingResponseErrorType
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
    public static class GetAccountBillingResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAccountBillingResponseErrorType value)
        {
            return value switch
            {
                GetAccountBillingResponseErrorType.AuthorizationError => "authorization_error",
                GetAccountBillingResponseErrorType.NotFound => "not_found",
                GetAccountBillingResponseErrorType.NotImplemented => "not_implemented",
                GetAccountBillingResponseErrorType.RateLimited => "rate_limited",
                GetAccountBillingResponseErrorType.ServerError => "server_error",
                GetAccountBillingResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAccountBillingResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAccountBillingResponseErrorType.AuthorizationError,
                "not_found" => GetAccountBillingResponseErrorType.NotFound,
                "not_implemented" => GetAccountBillingResponseErrorType.NotImplemented,
                "rate_limited" => GetAccountBillingResponseErrorType.RateLimited,
                "server_error" => GetAccountBillingResponseErrorType.ServerError,
                "validation_error" => GetAccountBillingResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}