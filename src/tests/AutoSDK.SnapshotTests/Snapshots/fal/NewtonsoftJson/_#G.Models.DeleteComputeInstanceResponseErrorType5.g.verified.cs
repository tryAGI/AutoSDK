//HintName: G.Models.DeleteComputeInstanceResponseErrorType5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeleteComputeInstanceResponseErrorType5
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
    public static class DeleteComputeInstanceResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteComputeInstanceResponseErrorType5 value)
        {
            return value switch
            {
                DeleteComputeInstanceResponseErrorType5.AuthorizationError => "authorization_error",
                DeleteComputeInstanceResponseErrorType5.NotFound => "not_found",
                DeleteComputeInstanceResponseErrorType5.NotImplemented => "not_implemented",
                DeleteComputeInstanceResponseErrorType5.RateLimited => "rate_limited",
                DeleteComputeInstanceResponseErrorType5.ServerError => "server_error",
                DeleteComputeInstanceResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteComputeInstanceResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteComputeInstanceResponseErrorType5.AuthorizationError,
                "not_found" => DeleteComputeInstanceResponseErrorType5.NotFound,
                "not_implemented" => DeleteComputeInstanceResponseErrorType5.NotImplemented,
                "rate_limited" => DeleteComputeInstanceResponseErrorType5.RateLimited,
                "server_error" => DeleteComputeInstanceResponseErrorType5.ServerError,
                "validation_error" => DeleteComputeInstanceResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}