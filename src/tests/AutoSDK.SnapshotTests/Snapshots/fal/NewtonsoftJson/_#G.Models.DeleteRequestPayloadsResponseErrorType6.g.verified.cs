//HintName: G.Models.DeleteRequestPayloadsResponseErrorType6.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeleteRequestPayloadsResponseErrorType6
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
    public static class DeleteRequestPayloadsResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteRequestPayloadsResponseErrorType6 value)
        {
            return value switch
            {
                DeleteRequestPayloadsResponseErrorType6.AuthorizationError => "authorization_error",
                DeleteRequestPayloadsResponseErrorType6.NotFound => "not_found",
                DeleteRequestPayloadsResponseErrorType6.NotImplemented => "not_implemented",
                DeleteRequestPayloadsResponseErrorType6.RateLimited => "rate_limited",
                DeleteRequestPayloadsResponseErrorType6.ServerError => "server_error",
                DeleteRequestPayloadsResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteRequestPayloadsResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteRequestPayloadsResponseErrorType6.AuthorizationError,
                "not_found" => DeleteRequestPayloadsResponseErrorType6.NotFound,
                "not_implemented" => DeleteRequestPayloadsResponseErrorType6.NotImplemented,
                "rate_limited" => DeleteRequestPayloadsResponseErrorType6.RateLimited,
                "server_error" => DeleteRequestPayloadsResponseErrorType6.ServerError,
                "validation_error" => DeleteRequestPayloadsResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}