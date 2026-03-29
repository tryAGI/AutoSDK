//HintName: G.Models.CreateApiKeyResponseErrorType3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateApiKeyResponseErrorType3
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
    public static class CreateApiKeyResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateApiKeyResponseErrorType3 value)
        {
            return value switch
            {
                CreateApiKeyResponseErrorType3.AuthorizationError => "authorization_error",
                CreateApiKeyResponseErrorType3.NotFound => "not_found",
                CreateApiKeyResponseErrorType3.NotImplemented => "not_implemented",
                CreateApiKeyResponseErrorType3.RateLimited => "rate_limited",
                CreateApiKeyResponseErrorType3.ServerError => "server_error",
                CreateApiKeyResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateApiKeyResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateApiKeyResponseErrorType3.AuthorizationError,
                "not_found" => CreateApiKeyResponseErrorType3.NotFound,
                "not_implemented" => CreateApiKeyResponseErrorType3.NotImplemented,
                "rate_limited" => CreateApiKeyResponseErrorType3.RateLimited,
                "server_error" => CreateApiKeyResponseErrorType3.ServerError,
                "validation_error" => CreateApiKeyResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}