//HintName: G.Models.GetWorkflowResponseErrorType4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetWorkflowResponseErrorType4
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
    public static class GetWorkflowResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWorkflowResponseErrorType4 value)
        {
            return value switch
            {
                GetWorkflowResponseErrorType4.AuthorizationError => "authorization_error",
                GetWorkflowResponseErrorType4.NotFound => "not_found",
                GetWorkflowResponseErrorType4.NotImplemented => "not_implemented",
                GetWorkflowResponseErrorType4.RateLimited => "rate_limited",
                GetWorkflowResponseErrorType4.ServerError => "server_error",
                GetWorkflowResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWorkflowResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetWorkflowResponseErrorType4.AuthorizationError,
                "not_found" => GetWorkflowResponseErrorType4.NotFound,
                "not_implemented" => GetWorkflowResponseErrorType4.NotImplemented,
                "rate_limited" => GetWorkflowResponseErrorType4.RateLimited,
                "server_error" => GetWorkflowResponseErrorType4.ServerError,
                "validation_error" => GetWorkflowResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}