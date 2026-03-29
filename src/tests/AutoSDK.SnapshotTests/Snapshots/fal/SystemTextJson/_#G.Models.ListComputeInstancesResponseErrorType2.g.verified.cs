//HintName: G.Models.ListComputeInstancesResponseErrorType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListComputeInstancesResponseErrorType2
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
    public static class ListComputeInstancesResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListComputeInstancesResponseErrorType2 value)
        {
            return value switch
            {
                ListComputeInstancesResponseErrorType2.AuthorizationError => "authorization_error",
                ListComputeInstancesResponseErrorType2.NotFound => "not_found",
                ListComputeInstancesResponseErrorType2.NotImplemented => "not_implemented",
                ListComputeInstancesResponseErrorType2.RateLimited => "rate_limited",
                ListComputeInstancesResponseErrorType2.ServerError => "server_error",
                ListComputeInstancesResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListComputeInstancesResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListComputeInstancesResponseErrorType2.AuthorizationError,
                "not_found" => ListComputeInstancesResponseErrorType2.NotFound,
                "not_implemented" => ListComputeInstancesResponseErrorType2.NotImplemented,
                "rate_limited" => ListComputeInstancesResponseErrorType2.RateLimited,
                "server_error" => ListComputeInstancesResponseErrorType2.ServerError,
                "validation_error" => ListComputeInstancesResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}