//HintName: G.Models.GetUsageResponseErrorType4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetUsageResponseErrorType4
    {
        /// <summary>
        /// 
        /// </summary>
        AuthorizationError,
        /// <summary>
        /// 
        /// </summary>
        NotFound,
        /// <summary>
        /// 
        /// </summary>
        NotImplemented,
        /// <summary>
        /// 
        /// </summary>
        RateLimited,
        /// <summary>
        /// 
        /// </summary>
        ServerError,
        /// <summary>
        /// 
        /// </summary>
        ValidationError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetUsageResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUsageResponseErrorType4 value)
        {
            return value switch
            {
                GetUsageResponseErrorType4.AuthorizationError => "authorization_error",
                GetUsageResponseErrorType4.NotFound => "not_found",
                GetUsageResponseErrorType4.NotImplemented => "not_implemented",
                GetUsageResponseErrorType4.RateLimited => "rate_limited",
                GetUsageResponseErrorType4.ServerError => "server_error",
                GetUsageResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUsageResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetUsageResponseErrorType4.AuthorizationError,
                "not_found" => GetUsageResponseErrorType4.NotFound,
                "not_implemented" => GetUsageResponseErrorType4.NotImplemented,
                "rate_limited" => GetUsageResponseErrorType4.RateLimited,
                "server_error" => GetUsageResponseErrorType4.ServerError,
                "validation_error" => GetUsageResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}