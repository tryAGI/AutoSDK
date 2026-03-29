//HintName: G.Models.ListWorkflowsResponseErrorType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListWorkflowsResponseErrorType2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="authorization_error")]
        AuthorizationError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_found")]
        NotFound,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_implemented")]
        NotImplemented,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rate_limited")]
        RateLimited,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="server_error")]
        ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="validation_error")]
        ValidationError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListWorkflowsResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListWorkflowsResponseErrorType2 value)
        {
            return value switch
            {
                ListWorkflowsResponseErrorType2.AuthorizationError => "authorization_error",
                ListWorkflowsResponseErrorType2.NotFound => "not_found",
                ListWorkflowsResponseErrorType2.NotImplemented => "not_implemented",
                ListWorkflowsResponseErrorType2.RateLimited => "rate_limited",
                ListWorkflowsResponseErrorType2.ServerError => "server_error",
                ListWorkflowsResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListWorkflowsResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListWorkflowsResponseErrorType2.AuthorizationError,
                "not_found" => ListWorkflowsResponseErrorType2.NotFound,
                "not_implemented" => ListWorkflowsResponseErrorType2.NotImplemented,
                "rate_limited" => ListWorkflowsResponseErrorType2.RateLimited,
                "server_error" => ListWorkflowsResponseErrorType2.ServerError,
                "validation_error" => ListWorkflowsResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}