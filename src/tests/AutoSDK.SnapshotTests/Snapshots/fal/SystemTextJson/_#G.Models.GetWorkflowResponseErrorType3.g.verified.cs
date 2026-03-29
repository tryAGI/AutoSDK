//HintName: G.Models.GetWorkflowResponseErrorType3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetWorkflowResponseErrorType3
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
    public static class GetWorkflowResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWorkflowResponseErrorType3 value)
        {
            return value switch
            {
                GetWorkflowResponseErrorType3.AuthorizationError => "authorization_error",
                GetWorkflowResponseErrorType3.NotFound => "not_found",
                GetWorkflowResponseErrorType3.NotImplemented => "not_implemented",
                GetWorkflowResponseErrorType3.RateLimited => "rate_limited",
                GetWorkflowResponseErrorType3.ServerError => "server_error",
                GetWorkflowResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWorkflowResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetWorkflowResponseErrorType3.AuthorizationError,
                "not_found" => GetWorkflowResponseErrorType3.NotFound,
                "not_implemented" => GetWorkflowResponseErrorType3.NotImplemented,
                "rate_limited" => GetWorkflowResponseErrorType3.RateLimited,
                "server_error" => GetWorkflowResponseErrorType3.ServerError,
                "validation_error" => GetWorkflowResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}