//HintName: G.Models.GetComputeInstanceResponseErrorType4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetComputeInstanceResponseErrorType4
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
    public static class GetComputeInstanceResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetComputeInstanceResponseErrorType4 value)
        {
            return value switch
            {
                GetComputeInstanceResponseErrorType4.AuthorizationError => "authorization_error",
                GetComputeInstanceResponseErrorType4.NotFound => "not_found",
                GetComputeInstanceResponseErrorType4.NotImplemented => "not_implemented",
                GetComputeInstanceResponseErrorType4.RateLimited => "rate_limited",
                GetComputeInstanceResponseErrorType4.ServerError => "server_error",
                GetComputeInstanceResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetComputeInstanceResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetComputeInstanceResponseErrorType4.AuthorizationError,
                "not_found" => GetComputeInstanceResponseErrorType4.NotFound,
                "not_implemented" => GetComputeInstanceResponseErrorType4.NotImplemented,
                "rate_limited" => GetComputeInstanceResponseErrorType4.RateLimited,
                "server_error" => GetComputeInstanceResponseErrorType4.ServerError,
                "validation_error" => GetComputeInstanceResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}