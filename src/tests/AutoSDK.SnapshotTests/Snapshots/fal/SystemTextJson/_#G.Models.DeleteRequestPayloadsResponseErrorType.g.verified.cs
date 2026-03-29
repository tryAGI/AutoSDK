//HintName: G.Models.DeleteRequestPayloadsResponseErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteRequestPayloadsResponseErrorType
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
    public static class DeleteRequestPayloadsResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteRequestPayloadsResponseErrorType value)
        {
            return value switch
            {
                DeleteRequestPayloadsResponseErrorType.AuthorizationError => "authorization_error",
                DeleteRequestPayloadsResponseErrorType.NotFound => "not_found",
                DeleteRequestPayloadsResponseErrorType.NotImplemented => "not_implemented",
                DeleteRequestPayloadsResponseErrorType.RateLimited => "rate_limited",
                DeleteRequestPayloadsResponseErrorType.ServerError => "server_error",
                DeleteRequestPayloadsResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteRequestPayloadsResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteRequestPayloadsResponseErrorType.AuthorizationError,
                "not_found" => DeleteRequestPayloadsResponseErrorType.NotFound,
                "not_implemented" => DeleteRequestPayloadsResponseErrorType.NotImplemented,
                "rate_limited" => DeleteRequestPayloadsResponseErrorType.RateLimited,
                "server_error" => DeleteRequestPayloadsResponseErrorType.ServerError,
                "validation_error" => DeleteRequestPayloadsResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}