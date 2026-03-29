//HintName: G.Models.ErrorDetailCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error code
    /// </summary>
    public enum ErrorDetailCode
    {
        /// <summary>
        /// 
        /// </summary>
        AuthenticationError,
        /// <summary>
        /// 
        /// </summary>
        InsufficientQuotaError,
        /// <summary>
        /// 
        /// </summary>
        InternalServerError,
        /// <summary>
        /// 
        /// </summary>
        InvalidApiKeyError,
        /// <summary>
        /// 
        /// </summary>
        InvalidRequestError,
        /// <summary>
        /// 
        /// </summary>
        NotFoundError,
        /// <summary>
        /// 
        /// </summary>
        RateLimitExceededError,
        /// <summary>
        /// 
        /// </summary>
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