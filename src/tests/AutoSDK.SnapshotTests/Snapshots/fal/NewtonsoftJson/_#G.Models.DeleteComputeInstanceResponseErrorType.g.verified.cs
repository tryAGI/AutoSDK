//HintName: G.Models.DeleteComputeInstanceResponseErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeleteComputeInstanceResponseErrorType
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
    public static class DeleteComputeInstanceResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteComputeInstanceResponseErrorType value)
        {
            return value switch
            {
                DeleteComputeInstanceResponseErrorType.AuthorizationError => "authorization_error",
                DeleteComputeInstanceResponseErrorType.NotFound => "not_found",
                DeleteComputeInstanceResponseErrorType.NotImplemented => "not_implemented",
                DeleteComputeInstanceResponseErrorType.RateLimited => "rate_limited",
                DeleteComputeInstanceResponseErrorType.ServerError => "server_error",
                DeleteComputeInstanceResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteComputeInstanceResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteComputeInstanceResponseErrorType.AuthorizationError,
                "not_found" => DeleteComputeInstanceResponseErrorType.NotFound,
                "not_implemented" => DeleteComputeInstanceResponseErrorType.NotImplemented,
                "rate_limited" => DeleteComputeInstanceResponseErrorType.RateLimited,
                "server_error" => DeleteComputeInstanceResponseErrorType.ServerError,
                "validation_error" => DeleteComputeInstanceResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}