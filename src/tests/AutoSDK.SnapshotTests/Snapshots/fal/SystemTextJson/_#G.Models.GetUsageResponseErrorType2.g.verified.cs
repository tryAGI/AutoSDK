//HintName: G.Models.GetUsageResponseErrorType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetUsageResponseErrorType2
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
    public static class GetUsageResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUsageResponseErrorType2 value)
        {
            return value switch
            {
                GetUsageResponseErrorType2.AuthorizationError => "authorization_error",
                GetUsageResponseErrorType2.NotFound => "not_found",
                GetUsageResponseErrorType2.NotImplemented => "not_implemented",
                GetUsageResponseErrorType2.RateLimited => "rate_limited",
                GetUsageResponseErrorType2.ServerError => "server_error",
                GetUsageResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUsageResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetUsageResponseErrorType2.AuthorizationError,
                "not_found" => GetUsageResponseErrorType2.NotFound,
                "not_implemented" => GetUsageResponseErrorType2.NotImplemented,
                "rate_limited" => GetUsageResponseErrorType2.RateLimited,
                "server_error" => GetUsageResponseErrorType2.ServerError,
                "validation_error" => GetUsageResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}