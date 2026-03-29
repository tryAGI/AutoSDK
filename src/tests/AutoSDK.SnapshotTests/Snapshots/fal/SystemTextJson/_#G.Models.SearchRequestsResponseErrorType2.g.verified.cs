//HintName: G.Models.SearchRequestsResponseErrorType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum SearchRequestsResponseErrorType2
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
    public static class SearchRequestsResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchRequestsResponseErrorType2 value)
        {
            return value switch
            {
                SearchRequestsResponseErrorType2.AuthorizationError => "authorization_error",
                SearchRequestsResponseErrorType2.NotFound => "not_found",
                SearchRequestsResponseErrorType2.NotImplemented => "not_implemented",
                SearchRequestsResponseErrorType2.RateLimited => "rate_limited",
                SearchRequestsResponseErrorType2.ServerError => "server_error",
                SearchRequestsResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchRequestsResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => SearchRequestsResponseErrorType2.AuthorizationError,
                "not_found" => SearchRequestsResponseErrorType2.NotFound,
                "not_implemented" => SearchRequestsResponseErrorType2.NotImplemented,
                "rate_limited" => SearchRequestsResponseErrorType2.RateLimited,
                "server_error" => SearchRequestsResponseErrorType2.ServerError,
                "validation_error" => SearchRequestsResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}