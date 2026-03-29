//HintName: G.Models.ServerlessUploadLocalFileResponseErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerlessUploadLocalFileResponseErrorType
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
    public static class ServerlessUploadLocalFileResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessUploadLocalFileResponseErrorType value)
        {
            return value switch
            {
                ServerlessUploadLocalFileResponseErrorType.AuthorizationError => "authorization_error",
                ServerlessUploadLocalFileResponseErrorType.NotFound => "not_found",
                ServerlessUploadLocalFileResponseErrorType.NotImplemented => "not_implemented",
                ServerlessUploadLocalFileResponseErrorType.RateLimited => "rate_limited",
                ServerlessUploadLocalFileResponseErrorType.ServerError => "server_error",
                ServerlessUploadLocalFileResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessUploadLocalFileResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessUploadLocalFileResponseErrorType.AuthorizationError,
                "not_found" => ServerlessUploadLocalFileResponseErrorType.NotFound,
                "not_implemented" => ServerlessUploadLocalFileResponseErrorType.NotImplemented,
                "rate_limited" => ServerlessUploadLocalFileResponseErrorType.RateLimited,
                "server_error" => ServerlessUploadLocalFileResponseErrorType.ServerError,
                "validation_error" => ServerlessUploadLocalFileResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}