//HintName: G.Models.CreateApiKeyResponseErrorType5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateApiKeyResponseErrorType5
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
    public static class CreateApiKeyResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateApiKeyResponseErrorType5 value)
        {
            return value switch
            {
                CreateApiKeyResponseErrorType5.AuthorizationError => "authorization_error",
                CreateApiKeyResponseErrorType5.NotFound => "not_found",
                CreateApiKeyResponseErrorType5.NotImplemented => "not_implemented",
                CreateApiKeyResponseErrorType5.RateLimited => "rate_limited",
                CreateApiKeyResponseErrorType5.ServerError => "server_error",
                CreateApiKeyResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateApiKeyResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateApiKeyResponseErrorType5.AuthorizationError,
                "not_found" => CreateApiKeyResponseErrorType5.NotFound,
                "not_implemented" => CreateApiKeyResponseErrorType5.NotImplemented,
                "rate_limited" => CreateApiKeyResponseErrorType5.RateLimited,
                "server_error" => CreateApiKeyResponseErrorType5.ServerError,
                "validation_error" => CreateApiKeyResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}