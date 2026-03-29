//HintName: G.Models.GetUsageResponseErrorType3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetUsageResponseErrorType3
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
    public static class GetUsageResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUsageResponseErrorType3 value)
        {
            return value switch
            {
                GetUsageResponseErrorType3.AuthorizationError => "authorization_error",
                GetUsageResponseErrorType3.NotFound => "not_found",
                GetUsageResponseErrorType3.NotImplemented => "not_implemented",
                GetUsageResponseErrorType3.RateLimited => "rate_limited",
                GetUsageResponseErrorType3.ServerError => "server_error",
                GetUsageResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUsageResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetUsageResponseErrorType3.AuthorizationError,
                "not_found" => GetUsageResponseErrorType3.NotFound,
                "not_implemented" => GetUsageResponseErrorType3.NotImplemented,
                "rate_limited" => GetUsageResponseErrorType3.RateLimited,
                "server_error" => GetUsageResponseErrorType3.ServerError,
                "validation_error" => GetUsageResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}