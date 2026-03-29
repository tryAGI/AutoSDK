//HintName: G.Models.CreateComputeInstanceResponseErrorType3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateComputeInstanceResponseErrorType3
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
    public static class CreateComputeInstanceResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateComputeInstanceResponseErrorType3 value)
        {
            return value switch
            {
                CreateComputeInstanceResponseErrorType3.AuthorizationError => "authorization_error",
                CreateComputeInstanceResponseErrorType3.NotFound => "not_found",
                CreateComputeInstanceResponseErrorType3.NotImplemented => "not_implemented",
                CreateComputeInstanceResponseErrorType3.RateLimited => "rate_limited",
                CreateComputeInstanceResponseErrorType3.ServerError => "server_error",
                CreateComputeInstanceResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateComputeInstanceResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateComputeInstanceResponseErrorType3.AuthorizationError,
                "not_found" => CreateComputeInstanceResponseErrorType3.NotFound,
                "not_implemented" => CreateComputeInstanceResponseErrorType3.NotImplemented,
                "rate_limited" => CreateComputeInstanceResponseErrorType3.RateLimited,
                "server_error" => CreateComputeInstanceResponseErrorType3.ServerError,
                "validation_error" => CreateComputeInstanceResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}