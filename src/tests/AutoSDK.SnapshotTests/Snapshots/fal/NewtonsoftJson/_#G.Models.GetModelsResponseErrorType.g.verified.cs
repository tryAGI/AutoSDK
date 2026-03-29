//HintName: G.Models.GetModelsResponseErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetModelsResponseErrorType
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
    public static class GetModelsResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsResponseErrorType value)
        {
            return value switch
            {
                GetModelsResponseErrorType.AuthorizationError => "authorization_error",
                GetModelsResponseErrorType.NotFound => "not_found",
                GetModelsResponseErrorType.NotImplemented => "not_implemented",
                GetModelsResponseErrorType.RateLimited => "rate_limited",
                GetModelsResponseErrorType.ServerError => "server_error",
                GetModelsResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetModelsResponseErrorType.AuthorizationError,
                "not_found" => GetModelsResponseErrorType.NotFound,
                "not_implemented" => GetModelsResponseErrorType.NotImplemented,
                "rate_limited" => GetModelsResponseErrorType.RateLimited,
                "server_error" => GetModelsResponseErrorType.ServerError,
                "validation_error" => GetModelsResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}