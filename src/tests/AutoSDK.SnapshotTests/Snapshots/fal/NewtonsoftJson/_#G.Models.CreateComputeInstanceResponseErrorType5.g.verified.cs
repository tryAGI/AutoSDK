//HintName: G.Models.CreateComputeInstanceResponseErrorType5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateComputeInstanceResponseErrorType5
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
    public static class CreateComputeInstanceResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateComputeInstanceResponseErrorType5 value)
        {
            return value switch
            {
                CreateComputeInstanceResponseErrorType5.AuthorizationError => "authorization_error",
                CreateComputeInstanceResponseErrorType5.NotFound => "not_found",
                CreateComputeInstanceResponseErrorType5.NotImplemented => "not_implemented",
                CreateComputeInstanceResponseErrorType5.RateLimited => "rate_limited",
                CreateComputeInstanceResponseErrorType5.ServerError => "server_error",
                CreateComputeInstanceResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateComputeInstanceResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateComputeInstanceResponseErrorType5.AuthorizationError,
                "not_found" => CreateComputeInstanceResponseErrorType5.NotFound,
                "not_implemented" => CreateComputeInstanceResponseErrorType5.NotImplemented,
                "rate_limited" => CreateComputeInstanceResponseErrorType5.RateLimited,
                "server_error" => CreateComputeInstanceResponseErrorType5.ServerError,
                "validation_error" => CreateComputeInstanceResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}