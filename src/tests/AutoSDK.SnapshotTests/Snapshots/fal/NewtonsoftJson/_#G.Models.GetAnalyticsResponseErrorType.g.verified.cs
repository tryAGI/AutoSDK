//HintName: G.Models.GetAnalyticsResponseErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAnalyticsResponseErrorType
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
    public static class GetAnalyticsResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsResponseErrorType value)
        {
            return value switch
            {
                GetAnalyticsResponseErrorType.AuthorizationError => "authorization_error",
                GetAnalyticsResponseErrorType.NotFound => "not_found",
                GetAnalyticsResponseErrorType.NotImplemented => "not_implemented",
                GetAnalyticsResponseErrorType.RateLimited => "rate_limited",
                GetAnalyticsResponseErrorType.ServerError => "server_error",
                GetAnalyticsResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAnalyticsResponseErrorType.AuthorizationError,
                "not_found" => GetAnalyticsResponseErrorType.NotFound,
                "not_implemented" => GetAnalyticsResponseErrorType.NotImplemented,
                "rate_limited" => GetAnalyticsResponseErrorType.RateLimited,
                "server_error" => GetAnalyticsResponseErrorType.ServerError,
                "validation_error" => GetAnalyticsResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}