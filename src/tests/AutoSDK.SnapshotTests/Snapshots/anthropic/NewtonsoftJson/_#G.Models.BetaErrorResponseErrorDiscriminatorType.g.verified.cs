//HintName: G.Models.BetaErrorResponseErrorDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaErrorResponseErrorDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="api_error")]
        ApiError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="authentication_error")]
        AuthenticationError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="invalid_request_error")]
        InvalidRequestError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_found_error")]
        NotFoundError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="overloaded_error")]
        OverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="permission_error")]
        PermissionError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rate_limit_error")]
        RateLimitError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaErrorResponseErrorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaErrorResponseErrorDiscriminatorType value)
        {
            return value switch
            {
                BetaErrorResponseErrorDiscriminatorType.ApiError => "api_error",
                BetaErrorResponseErrorDiscriminatorType.AuthenticationError => "authentication_error",
                BetaErrorResponseErrorDiscriminatorType.InvalidRequestError => "invalid_request_error",
                BetaErrorResponseErrorDiscriminatorType.NotFoundError => "not_found_error",
                BetaErrorResponseErrorDiscriminatorType.OverloadedError => "overloaded_error",
                BetaErrorResponseErrorDiscriminatorType.PermissionError => "permission_error",
                BetaErrorResponseErrorDiscriminatorType.RateLimitError => "rate_limit_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaErrorResponseErrorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "api_error" => BetaErrorResponseErrorDiscriminatorType.ApiError,
                "authentication_error" => BetaErrorResponseErrorDiscriminatorType.AuthenticationError,
                "invalid_request_error" => BetaErrorResponseErrorDiscriminatorType.InvalidRequestError,
                "not_found_error" => BetaErrorResponseErrorDiscriminatorType.NotFoundError,
                "overloaded_error" => BetaErrorResponseErrorDiscriminatorType.OverloadedError,
                "permission_error" => BetaErrorResponseErrorDiscriminatorType.PermissionError,
                "rate_limit_error" => BetaErrorResponseErrorDiscriminatorType.RateLimitError,
                _ => null,
            };
        }
    }
}