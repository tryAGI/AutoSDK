//HintName: G.Models.CreateApiKeyResponseErrorType4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateApiKeyResponseErrorType4
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
    public static class CreateApiKeyResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateApiKeyResponseErrorType4 value)
        {
            return value switch
            {
                CreateApiKeyResponseErrorType4.AuthorizationError => "authorization_error",
                CreateApiKeyResponseErrorType4.NotFound => "not_found",
                CreateApiKeyResponseErrorType4.NotImplemented => "not_implemented",
                CreateApiKeyResponseErrorType4.RateLimited => "rate_limited",
                CreateApiKeyResponseErrorType4.ServerError => "server_error",
                CreateApiKeyResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateApiKeyResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateApiKeyResponseErrorType4.AuthorizationError,
                "not_found" => CreateApiKeyResponseErrorType4.NotFound,
                "not_implemented" => CreateApiKeyResponseErrorType4.NotImplemented,
                "rate_limited" => CreateApiKeyResponseErrorType4.RateLimited,
                "server_error" => CreateApiKeyResponseErrorType4.ServerError,
                "validation_error" => CreateApiKeyResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}