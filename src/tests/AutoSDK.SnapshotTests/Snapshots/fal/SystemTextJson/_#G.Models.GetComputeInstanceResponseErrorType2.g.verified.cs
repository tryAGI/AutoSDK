//HintName: G.Models.GetComputeInstanceResponseErrorType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetComputeInstanceResponseErrorType2
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
    public static class GetComputeInstanceResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetComputeInstanceResponseErrorType2 value)
        {
            return value switch
            {
                GetComputeInstanceResponseErrorType2.AuthorizationError => "authorization_error",
                GetComputeInstanceResponseErrorType2.NotFound => "not_found",
                GetComputeInstanceResponseErrorType2.NotImplemented => "not_implemented",
                GetComputeInstanceResponseErrorType2.RateLimited => "rate_limited",
                GetComputeInstanceResponseErrorType2.ServerError => "server_error",
                GetComputeInstanceResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetComputeInstanceResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetComputeInstanceResponseErrorType2.AuthorizationError,
                "not_found" => GetComputeInstanceResponseErrorType2.NotFound,
                "not_implemented" => GetComputeInstanceResponseErrorType2.NotImplemented,
                "rate_limited" => GetComputeInstanceResponseErrorType2.RateLimited,
                "server_error" => GetComputeInstanceResponseErrorType2.ServerError,
                "validation_error" => GetComputeInstanceResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}