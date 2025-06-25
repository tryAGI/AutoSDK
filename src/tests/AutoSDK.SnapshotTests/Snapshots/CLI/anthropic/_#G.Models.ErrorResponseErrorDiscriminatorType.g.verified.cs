//HintName: G.Models.ErrorResponseErrorDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ErrorResponseErrorDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ApiError,
        /// <summary>
        /// 
        /// </summary>
        AuthenticationError,
        /// <summary>
        /// 
        /// </summary>
        BillingError,
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
        OverloadedError,
        /// <summary>
        /// 
        /// </summary>
        PermissionError,
        /// <summary>
        /// 
        /// </summary>
        RateLimitError,
        /// <summary>
        /// 
        /// </summary>
        TimeoutError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ErrorResponseErrorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ErrorResponseErrorDiscriminatorType value)
        {
            return value switch
            {
                ErrorResponseErrorDiscriminatorType.ApiError => "api_error",
                ErrorResponseErrorDiscriminatorType.AuthenticationError => "authentication_error",
                ErrorResponseErrorDiscriminatorType.BillingError => "billing_error",
                ErrorResponseErrorDiscriminatorType.InvalidRequestError => "invalid_request_error",
                ErrorResponseErrorDiscriminatorType.NotFoundError => "not_found_error",
                ErrorResponseErrorDiscriminatorType.OverloadedError => "overloaded_error",
                ErrorResponseErrorDiscriminatorType.PermissionError => "permission_error",
                ErrorResponseErrorDiscriminatorType.RateLimitError => "rate_limit_error",
                ErrorResponseErrorDiscriminatorType.TimeoutError => "timeout_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ErrorResponseErrorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "api_error" => ErrorResponseErrorDiscriminatorType.ApiError,
                "authentication_error" => ErrorResponseErrorDiscriminatorType.AuthenticationError,
                "billing_error" => ErrorResponseErrorDiscriminatorType.BillingError,
                "invalid_request_error" => ErrorResponseErrorDiscriminatorType.InvalidRequestError,
                "not_found_error" => ErrorResponseErrorDiscriminatorType.NotFoundError,
                "overloaded_error" => ErrorResponseErrorDiscriminatorType.OverloadedError,
                "permission_error" => ErrorResponseErrorDiscriminatorType.PermissionError,
                "rate_limit_error" => ErrorResponseErrorDiscriminatorType.RateLimitError,
                "timeout_error" => ErrorResponseErrorDiscriminatorType.TimeoutError,
                _ => null,
            };
        }
    }
}