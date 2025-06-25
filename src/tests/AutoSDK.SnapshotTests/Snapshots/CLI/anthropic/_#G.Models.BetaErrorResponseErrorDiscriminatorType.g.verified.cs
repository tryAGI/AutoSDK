//HintName: G.Models.BetaErrorResponseErrorDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaErrorResponseErrorDiscriminatorType
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
                BetaErrorResponseErrorDiscriminatorType.BillingError => "billing_error",
                BetaErrorResponseErrorDiscriminatorType.InvalidRequestError => "invalid_request_error",
                BetaErrorResponseErrorDiscriminatorType.NotFoundError => "not_found_error",
                BetaErrorResponseErrorDiscriminatorType.OverloadedError => "overloaded_error",
                BetaErrorResponseErrorDiscriminatorType.PermissionError => "permission_error",
                BetaErrorResponseErrorDiscriminatorType.RateLimitError => "rate_limit_error",
                BetaErrorResponseErrorDiscriminatorType.TimeoutError => "timeout_error",
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
                "billing_error" => BetaErrorResponseErrorDiscriminatorType.BillingError,
                "invalid_request_error" => BetaErrorResponseErrorDiscriminatorType.InvalidRequestError,
                "not_found_error" => BetaErrorResponseErrorDiscriminatorType.NotFoundError,
                "overloaded_error" => BetaErrorResponseErrorDiscriminatorType.OverloadedError,
                "permission_error" => BetaErrorResponseErrorDiscriminatorType.PermissionError,
                "rate_limit_error" => BetaErrorResponseErrorDiscriminatorType.RateLimitError,
                "timeout_error" => BetaErrorResponseErrorDiscriminatorType.TimeoutError,
                _ => null,
            };
        }
    }
}