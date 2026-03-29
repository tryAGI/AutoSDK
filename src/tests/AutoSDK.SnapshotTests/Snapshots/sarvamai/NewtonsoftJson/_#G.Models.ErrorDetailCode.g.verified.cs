//HintName: G.Models.ErrorDetailCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error code
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ErrorDetailCode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="authentication_error")]
        AuthenticationError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="insufficient_quota_error")]
        InsufficientQuotaError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="internal_server_error")]
        InternalServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="invalid_api_key_error")]
        InvalidApiKeyError,
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
        [global::System.Runtime.Serialization.EnumMember(Value="rate_limit_exceeded_error")]
        RateLimitExceededError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unprocessable_entity_error")]
        UnprocessableEntityError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ErrorDetailCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ErrorDetailCode value)
        {
            return value switch
            {
                ErrorDetailCode.AuthenticationError => "authentication_error",
                ErrorDetailCode.InsufficientQuotaError => "insufficient_quota_error",
                ErrorDetailCode.InternalServerError => "internal_server_error",
                ErrorDetailCode.InvalidApiKeyError => "invalid_api_key_error",
                ErrorDetailCode.InvalidRequestError => "invalid_request_error",
                ErrorDetailCode.NotFoundError => "not_found_error",
                ErrorDetailCode.RateLimitExceededError => "rate_limit_exceeded_error",
                ErrorDetailCode.UnprocessableEntityError => "unprocessable_entity_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ErrorDetailCode? ToEnum(string value)
        {
            return value switch
            {
                "authentication_error" => ErrorDetailCode.AuthenticationError,
                "insufficient_quota_error" => ErrorDetailCode.InsufficientQuotaError,
                "internal_server_error" => ErrorDetailCode.InternalServerError,
                "invalid_api_key_error" => ErrorDetailCode.InvalidApiKeyError,
                "invalid_request_error" => ErrorDetailCode.InvalidRequestError,
                "not_found_error" => ErrorDetailCode.NotFoundError,
                "rate_limit_exceeded_error" => ErrorDetailCode.RateLimitExceededError,
                "unprocessable_entity_error" => ErrorDetailCode.UnprocessableEntityError,
                _ => null,
            };
        }
    }
}