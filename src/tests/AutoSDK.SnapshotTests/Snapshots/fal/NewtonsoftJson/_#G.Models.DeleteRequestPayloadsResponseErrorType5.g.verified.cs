//HintName: G.Models.DeleteRequestPayloadsResponseErrorType5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeleteRequestPayloadsResponseErrorType5
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
    public static class DeleteRequestPayloadsResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteRequestPayloadsResponseErrorType5 value)
        {
            return value switch
            {
                DeleteRequestPayloadsResponseErrorType5.AuthorizationError => "authorization_error",
                DeleteRequestPayloadsResponseErrorType5.NotFound => "not_found",
                DeleteRequestPayloadsResponseErrorType5.NotImplemented => "not_implemented",
                DeleteRequestPayloadsResponseErrorType5.RateLimited => "rate_limited",
                DeleteRequestPayloadsResponseErrorType5.ServerError => "server_error",
                DeleteRequestPayloadsResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteRequestPayloadsResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteRequestPayloadsResponseErrorType5.AuthorizationError,
                "not_found" => DeleteRequestPayloadsResponseErrorType5.NotFound,
                "not_implemented" => DeleteRequestPayloadsResponseErrorType5.NotImplemented,
                "rate_limited" => DeleteRequestPayloadsResponseErrorType5.RateLimited,
                "server_error" => DeleteRequestPayloadsResponseErrorType5.ServerError,
                "validation_error" => DeleteRequestPayloadsResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}