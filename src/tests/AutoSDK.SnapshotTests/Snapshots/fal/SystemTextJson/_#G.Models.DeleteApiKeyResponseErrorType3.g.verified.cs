//HintName: G.Models.DeleteApiKeyResponseErrorType3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteApiKeyResponseErrorType3
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
    public static class DeleteApiKeyResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteApiKeyResponseErrorType3 value)
        {
            return value switch
            {
                DeleteApiKeyResponseErrorType3.AuthorizationError => "authorization_error",
                DeleteApiKeyResponseErrorType3.NotFound => "not_found",
                DeleteApiKeyResponseErrorType3.NotImplemented => "not_implemented",
                DeleteApiKeyResponseErrorType3.RateLimited => "rate_limited",
                DeleteApiKeyResponseErrorType3.ServerError => "server_error",
                DeleteApiKeyResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteApiKeyResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteApiKeyResponseErrorType3.AuthorizationError,
                "not_found" => DeleteApiKeyResponseErrorType3.NotFound,
                "not_implemented" => DeleteApiKeyResponseErrorType3.NotImplemented,
                "rate_limited" => DeleteApiKeyResponseErrorType3.RateLimited,
                "server_error" => DeleteApiKeyResponseErrorType3.ServerError,
                "validation_error" => DeleteApiKeyResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}