//HintName: G.Models.ListApiKeysResponseErrorType3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListApiKeysResponseErrorType3
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
    public static class ListApiKeysResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListApiKeysResponseErrorType3 value)
        {
            return value switch
            {
                ListApiKeysResponseErrorType3.AuthorizationError => "authorization_error",
                ListApiKeysResponseErrorType3.NotFound => "not_found",
                ListApiKeysResponseErrorType3.NotImplemented => "not_implemented",
                ListApiKeysResponseErrorType3.RateLimited => "rate_limited",
                ListApiKeysResponseErrorType3.ServerError => "server_error",
                ListApiKeysResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListApiKeysResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListApiKeysResponseErrorType3.AuthorizationError,
                "not_found" => ListApiKeysResponseErrorType3.NotFound,
                "not_implemented" => ListApiKeysResponseErrorType3.NotImplemented,
                "rate_limited" => ListApiKeysResponseErrorType3.RateLimited,
                "server_error" => ListApiKeysResponseErrorType3.ServerError,
                "validation_error" => ListApiKeysResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}