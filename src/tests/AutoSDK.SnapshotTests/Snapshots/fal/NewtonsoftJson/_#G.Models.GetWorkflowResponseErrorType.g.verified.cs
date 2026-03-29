//HintName: G.Models.GetWorkflowResponseErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetWorkflowResponseErrorType
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
    public static class GetWorkflowResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWorkflowResponseErrorType value)
        {
            return value switch
            {
                GetWorkflowResponseErrorType.AuthorizationError => "authorization_error",
                GetWorkflowResponseErrorType.NotFound => "not_found",
                GetWorkflowResponseErrorType.NotImplemented => "not_implemented",
                GetWorkflowResponseErrorType.RateLimited => "rate_limited",
                GetWorkflowResponseErrorType.ServerError => "server_error",
                GetWorkflowResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWorkflowResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetWorkflowResponseErrorType.AuthorizationError,
                "not_found" => GetWorkflowResponseErrorType.NotFound,
                "not_implemented" => GetWorkflowResponseErrorType.NotImplemented,
                "rate_limited" => GetWorkflowResponseErrorType.RateLimited,
                "server_error" => GetWorkflowResponseErrorType.ServerError,
                "validation_error" => GetWorkflowResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}