//HintName: G.Models.GetComputeInstanceResponseErrorType5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetComputeInstanceResponseErrorType5
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
    public static class GetComputeInstanceResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetComputeInstanceResponseErrorType5 value)
        {
            return value switch
            {
                GetComputeInstanceResponseErrorType5.AuthorizationError => "authorization_error",
                GetComputeInstanceResponseErrorType5.NotFound => "not_found",
                GetComputeInstanceResponseErrorType5.NotImplemented => "not_implemented",
                GetComputeInstanceResponseErrorType5.RateLimited => "rate_limited",
                GetComputeInstanceResponseErrorType5.ServerError => "server_error",
                GetComputeInstanceResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetComputeInstanceResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetComputeInstanceResponseErrorType5.AuthorizationError,
                "not_found" => GetComputeInstanceResponseErrorType5.NotFound,
                "not_implemented" => GetComputeInstanceResponseErrorType5.NotImplemented,
                "rate_limited" => GetComputeInstanceResponseErrorType5.RateLimited,
                "server_error" => GetComputeInstanceResponseErrorType5.ServerError,
                "validation_error" => GetComputeInstanceResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}