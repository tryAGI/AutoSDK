//HintName: G.Models.GetWorkflowResponseErrorType6.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetWorkflowResponseErrorType6
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
    public static class GetWorkflowResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWorkflowResponseErrorType6 value)
        {
            return value switch
            {
                GetWorkflowResponseErrorType6.AuthorizationError => "authorization_error",
                GetWorkflowResponseErrorType6.NotFound => "not_found",
                GetWorkflowResponseErrorType6.NotImplemented => "not_implemented",
                GetWorkflowResponseErrorType6.RateLimited => "rate_limited",
                GetWorkflowResponseErrorType6.ServerError => "server_error",
                GetWorkflowResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWorkflowResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetWorkflowResponseErrorType6.AuthorizationError,
                "not_found" => GetWorkflowResponseErrorType6.NotFound,
                "not_implemented" => GetWorkflowResponseErrorType6.NotImplemented,
                "rate_limited" => GetWorkflowResponseErrorType6.RateLimited,
                "server_error" => GetWorkflowResponseErrorType6.ServerError,
                "validation_error" => GetWorkflowResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}