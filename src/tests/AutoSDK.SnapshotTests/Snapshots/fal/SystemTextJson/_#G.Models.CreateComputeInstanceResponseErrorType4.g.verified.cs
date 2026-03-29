//HintName: G.Models.CreateComputeInstanceResponseErrorType4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateComputeInstanceResponseErrorType4
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
    public static class CreateComputeInstanceResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateComputeInstanceResponseErrorType4 value)
        {
            return value switch
            {
                CreateComputeInstanceResponseErrorType4.AuthorizationError => "authorization_error",
                CreateComputeInstanceResponseErrorType4.NotFound => "not_found",
                CreateComputeInstanceResponseErrorType4.NotImplemented => "not_implemented",
                CreateComputeInstanceResponseErrorType4.RateLimited => "rate_limited",
                CreateComputeInstanceResponseErrorType4.ServerError => "server_error",
                CreateComputeInstanceResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateComputeInstanceResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateComputeInstanceResponseErrorType4.AuthorizationError,
                "not_found" => CreateComputeInstanceResponseErrorType4.NotFound,
                "not_implemented" => CreateComputeInstanceResponseErrorType4.NotImplemented,
                "rate_limited" => CreateComputeInstanceResponseErrorType4.RateLimited,
                "server_error" => CreateComputeInstanceResponseErrorType4.ServerError,
                "validation_error" => CreateComputeInstanceResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}