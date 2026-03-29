//HintName: G.Models.GetAccountBillingResponseErrorType4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAccountBillingResponseErrorType4
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
    public static class GetAccountBillingResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAccountBillingResponseErrorType4 value)
        {
            return value switch
            {
                GetAccountBillingResponseErrorType4.AuthorizationError => "authorization_error",
                GetAccountBillingResponseErrorType4.NotFound => "not_found",
                GetAccountBillingResponseErrorType4.NotImplemented => "not_implemented",
                GetAccountBillingResponseErrorType4.RateLimited => "rate_limited",
                GetAccountBillingResponseErrorType4.ServerError => "server_error",
                GetAccountBillingResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAccountBillingResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAccountBillingResponseErrorType4.AuthorizationError,
                "not_found" => GetAccountBillingResponseErrorType4.NotFound,
                "not_implemented" => GetAccountBillingResponseErrorType4.NotImplemented,
                "rate_limited" => GetAccountBillingResponseErrorType4.RateLimited,
                "server_error" => GetAccountBillingResponseErrorType4.ServerError,
                "validation_error" => GetAccountBillingResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}