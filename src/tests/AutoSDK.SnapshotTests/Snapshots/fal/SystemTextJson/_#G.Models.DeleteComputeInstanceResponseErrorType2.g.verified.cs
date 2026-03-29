//HintName: G.Models.DeleteComputeInstanceResponseErrorType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteComputeInstanceResponseErrorType2
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
    public static class DeleteComputeInstanceResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteComputeInstanceResponseErrorType2 value)
        {
            return value switch
            {
                DeleteComputeInstanceResponseErrorType2.AuthorizationError => "authorization_error",
                DeleteComputeInstanceResponseErrorType2.NotFound => "not_found",
                DeleteComputeInstanceResponseErrorType2.NotImplemented => "not_implemented",
                DeleteComputeInstanceResponseErrorType2.RateLimited => "rate_limited",
                DeleteComputeInstanceResponseErrorType2.ServerError => "server_error",
                DeleteComputeInstanceResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteComputeInstanceResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteComputeInstanceResponseErrorType2.AuthorizationError,
                "not_found" => DeleteComputeInstanceResponseErrorType2.NotFound,
                "not_implemented" => DeleteComputeInstanceResponseErrorType2.NotImplemented,
                "rate_limited" => DeleteComputeInstanceResponseErrorType2.RateLimited,
                "server_error" => DeleteComputeInstanceResponseErrorType2.ServerError,
                "validation_error" => DeleteComputeInstanceResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}