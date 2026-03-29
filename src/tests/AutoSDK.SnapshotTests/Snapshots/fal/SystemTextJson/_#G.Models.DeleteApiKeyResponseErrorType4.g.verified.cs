//HintName: G.Models.DeleteApiKeyResponseErrorType4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteApiKeyResponseErrorType4
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
    public static class DeleteApiKeyResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteApiKeyResponseErrorType4 value)
        {
            return value switch
            {
                DeleteApiKeyResponseErrorType4.AuthorizationError => "authorization_error",
                DeleteApiKeyResponseErrorType4.NotFound => "not_found",
                DeleteApiKeyResponseErrorType4.NotImplemented => "not_implemented",
                DeleteApiKeyResponseErrorType4.RateLimited => "rate_limited",
                DeleteApiKeyResponseErrorType4.ServerError => "server_error",
                DeleteApiKeyResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteApiKeyResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteApiKeyResponseErrorType4.AuthorizationError,
                "not_found" => DeleteApiKeyResponseErrorType4.NotFound,
                "not_implemented" => DeleteApiKeyResponseErrorType4.NotImplemented,
                "rate_limited" => DeleteApiKeyResponseErrorType4.RateLimited,
                "server_error" => DeleteApiKeyResponseErrorType4.ServerError,
                "validation_error" => DeleteApiKeyResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}