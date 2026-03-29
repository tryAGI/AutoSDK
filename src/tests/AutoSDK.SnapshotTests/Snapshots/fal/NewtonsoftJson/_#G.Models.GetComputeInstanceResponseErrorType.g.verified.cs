//HintName: G.Models.GetComputeInstanceResponseErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetComputeInstanceResponseErrorType
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
    public static class GetComputeInstanceResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetComputeInstanceResponseErrorType value)
        {
            return value switch
            {
                GetComputeInstanceResponseErrorType.AuthorizationError => "authorization_error",
                GetComputeInstanceResponseErrorType.NotFound => "not_found",
                GetComputeInstanceResponseErrorType.NotImplemented => "not_implemented",
                GetComputeInstanceResponseErrorType.RateLimited => "rate_limited",
                GetComputeInstanceResponseErrorType.ServerError => "server_error",
                GetComputeInstanceResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetComputeInstanceResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetComputeInstanceResponseErrorType.AuthorizationError,
                "not_found" => GetComputeInstanceResponseErrorType.NotFound,
                "not_implemented" => GetComputeInstanceResponseErrorType.NotImplemented,
                "rate_limited" => GetComputeInstanceResponseErrorType.RateLimited,
                "server_error" => GetComputeInstanceResponseErrorType.ServerError,
                "validation_error" => GetComputeInstanceResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}