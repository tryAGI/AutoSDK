//HintName: G.Models.GetModelsResponseErrorType3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetModelsResponseErrorType3
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
    public static class GetModelsResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsResponseErrorType3 value)
        {
            return value switch
            {
                GetModelsResponseErrorType3.AuthorizationError => "authorization_error",
                GetModelsResponseErrorType3.NotFound => "not_found",
                GetModelsResponseErrorType3.NotImplemented => "not_implemented",
                GetModelsResponseErrorType3.RateLimited => "rate_limited",
                GetModelsResponseErrorType3.ServerError => "server_error",
                GetModelsResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetModelsResponseErrorType3.AuthorizationError,
                "not_found" => GetModelsResponseErrorType3.NotFound,
                "not_implemented" => GetModelsResponseErrorType3.NotImplemented,
                "rate_limited" => GetModelsResponseErrorType3.RateLimited,
                "server_error" => GetModelsResponseErrorType3.ServerError,
                "validation_error" => GetModelsResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}