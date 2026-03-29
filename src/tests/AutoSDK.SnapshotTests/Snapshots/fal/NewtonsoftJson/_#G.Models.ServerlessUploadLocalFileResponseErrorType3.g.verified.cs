//HintName: G.Models.ServerlessUploadLocalFileResponseErrorType3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerlessUploadLocalFileResponseErrorType3
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
    public static class ServerlessUploadLocalFileResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessUploadLocalFileResponseErrorType3 value)
        {
            return value switch
            {
                ServerlessUploadLocalFileResponseErrorType3.AuthorizationError => "authorization_error",
                ServerlessUploadLocalFileResponseErrorType3.NotFound => "not_found",
                ServerlessUploadLocalFileResponseErrorType3.NotImplemented => "not_implemented",
                ServerlessUploadLocalFileResponseErrorType3.RateLimited => "rate_limited",
                ServerlessUploadLocalFileResponseErrorType3.ServerError => "server_error",
                ServerlessUploadLocalFileResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessUploadLocalFileResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessUploadLocalFileResponseErrorType3.AuthorizationError,
                "not_found" => ServerlessUploadLocalFileResponseErrorType3.NotFound,
                "not_implemented" => ServerlessUploadLocalFileResponseErrorType3.NotImplemented,
                "rate_limited" => ServerlessUploadLocalFileResponseErrorType3.RateLimited,
                "server_error" => ServerlessUploadLocalFileResponseErrorType3.ServerError,
                "validation_error" => ServerlessUploadLocalFileResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}