//HintName: G.Models.CreateComputeInstanceResponseErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateComputeInstanceResponseErrorType
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
    public static class CreateComputeInstanceResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateComputeInstanceResponseErrorType value)
        {
            return value switch
            {
                CreateComputeInstanceResponseErrorType.AuthorizationError => "authorization_error",
                CreateComputeInstanceResponseErrorType.NotFound => "not_found",
                CreateComputeInstanceResponseErrorType.NotImplemented => "not_implemented",
                CreateComputeInstanceResponseErrorType.RateLimited => "rate_limited",
                CreateComputeInstanceResponseErrorType.ServerError => "server_error",
                CreateComputeInstanceResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateComputeInstanceResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateComputeInstanceResponseErrorType.AuthorizationError,
                "not_found" => CreateComputeInstanceResponseErrorType.NotFound,
                "not_implemented" => CreateComputeInstanceResponseErrorType.NotImplemented,
                "rate_limited" => CreateComputeInstanceResponseErrorType.RateLimited,
                "server_error" => CreateComputeInstanceResponseErrorType.ServerError,
                "validation_error" => CreateComputeInstanceResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}