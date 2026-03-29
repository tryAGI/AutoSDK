//HintName: G.Models.GetMetaResponseErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetMetaResponseErrorType
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
    public static class GetMetaResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMetaResponseErrorType value)
        {
            return value switch
            {
                GetMetaResponseErrorType.AuthorizationError => "authorization_error",
                GetMetaResponseErrorType.NotFound => "not_found",
                GetMetaResponseErrorType.NotImplemented => "not_implemented",
                GetMetaResponseErrorType.RateLimited => "rate_limited",
                GetMetaResponseErrorType.ServerError => "server_error",
                GetMetaResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMetaResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetMetaResponseErrorType.AuthorizationError,
                "not_found" => GetMetaResponseErrorType.NotFound,
                "not_implemented" => GetMetaResponseErrorType.NotImplemented,
                "rate_limited" => GetMetaResponseErrorType.RateLimited,
                "server_error" => GetMetaResponseErrorType.ServerError,
                "validation_error" => GetMetaResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}