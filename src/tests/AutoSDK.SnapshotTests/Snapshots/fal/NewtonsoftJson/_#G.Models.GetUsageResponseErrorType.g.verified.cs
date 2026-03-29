//HintName: G.Models.GetUsageResponseErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetUsageResponseErrorType
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
    public static class GetUsageResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUsageResponseErrorType value)
        {
            return value switch
            {
                GetUsageResponseErrorType.AuthorizationError => "authorization_error",
                GetUsageResponseErrorType.NotFound => "not_found",
                GetUsageResponseErrorType.NotImplemented => "not_implemented",
                GetUsageResponseErrorType.RateLimited => "rate_limited",
                GetUsageResponseErrorType.ServerError => "server_error",
                GetUsageResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUsageResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetUsageResponseErrorType.AuthorizationError,
                "not_found" => GetUsageResponseErrorType.NotFound,
                "not_implemented" => GetUsageResponseErrorType.NotImplemented,
                "rate_limited" => GetUsageResponseErrorType.RateLimited,
                "server_error" => GetUsageResponseErrorType.ServerError,
                "validation_error" => GetUsageResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}