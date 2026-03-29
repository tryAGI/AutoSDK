//HintName: G.Models.ListWorkflowsResponseErrorType4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListWorkflowsResponseErrorType4
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
    public static class ListWorkflowsResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListWorkflowsResponseErrorType4 value)
        {
            return value switch
            {
                ListWorkflowsResponseErrorType4.AuthorizationError => "authorization_error",
                ListWorkflowsResponseErrorType4.NotFound => "not_found",
                ListWorkflowsResponseErrorType4.NotImplemented => "not_implemented",
                ListWorkflowsResponseErrorType4.RateLimited => "rate_limited",
                ListWorkflowsResponseErrorType4.ServerError => "server_error",
                ListWorkflowsResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListWorkflowsResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListWorkflowsResponseErrorType4.AuthorizationError,
                "not_found" => ListWorkflowsResponseErrorType4.NotFound,
                "not_implemented" => ListWorkflowsResponseErrorType4.NotImplemented,
                "rate_limited" => ListWorkflowsResponseErrorType4.RateLimited,
                "server_error" => ListWorkflowsResponseErrorType4.ServerError,
                "validation_error" => ListWorkflowsResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}