//HintName: G.Models.CreateApiKeyResponseErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateApiKeyResponseErrorType
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
    public static class CreateApiKeyResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateApiKeyResponseErrorType value)
        {
            return value switch
            {
                CreateApiKeyResponseErrorType.AuthorizationError => "authorization_error",
                CreateApiKeyResponseErrorType.NotFound => "not_found",
                CreateApiKeyResponseErrorType.NotImplemented => "not_implemented",
                CreateApiKeyResponseErrorType.RateLimited => "rate_limited",
                CreateApiKeyResponseErrorType.ServerError => "server_error",
                CreateApiKeyResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateApiKeyResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateApiKeyResponseErrorType.AuthorizationError,
                "not_found" => CreateApiKeyResponseErrorType.NotFound,
                "not_implemented" => CreateApiKeyResponseErrorType.NotImplemented,
                "rate_limited" => CreateApiKeyResponseErrorType.RateLimited,
                "server_error" => CreateApiKeyResponseErrorType.ServerError,
                "validation_error" => CreateApiKeyResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}