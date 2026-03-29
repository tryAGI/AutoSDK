//HintName: G.Models.GetComputeInstanceResponseErrorType3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetComputeInstanceResponseErrorType3
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
    public static class GetComputeInstanceResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetComputeInstanceResponseErrorType3 value)
        {
            return value switch
            {
                GetComputeInstanceResponseErrorType3.AuthorizationError => "authorization_error",
                GetComputeInstanceResponseErrorType3.NotFound => "not_found",
                GetComputeInstanceResponseErrorType3.NotImplemented => "not_implemented",
                GetComputeInstanceResponseErrorType3.RateLimited => "rate_limited",
                GetComputeInstanceResponseErrorType3.ServerError => "server_error",
                GetComputeInstanceResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetComputeInstanceResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetComputeInstanceResponseErrorType3.AuthorizationError,
                "not_found" => GetComputeInstanceResponseErrorType3.NotFound,
                "not_implemented" => GetComputeInstanceResponseErrorType3.NotImplemented,
                "rate_limited" => GetComputeInstanceResponseErrorType3.RateLimited,
                "server_error" => GetComputeInstanceResponseErrorType3.ServerError,
                "validation_error" => GetComputeInstanceResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}