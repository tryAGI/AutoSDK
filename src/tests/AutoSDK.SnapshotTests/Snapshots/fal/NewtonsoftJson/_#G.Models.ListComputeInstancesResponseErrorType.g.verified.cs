//HintName: G.Models.ListComputeInstancesResponseErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListComputeInstancesResponseErrorType
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
    public static class ListComputeInstancesResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListComputeInstancesResponseErrorType value)
        {
            return value switch
            {
                ListComputeInstancesResponseErrorType.AuthorizationError => "authorization_error",
                ListComputeInstancesResponseErrorType.NotFound => "not_found",
                ListComputeInstancesResponseErrorType.NotImplemented => "not_implemented",
                ListComputeInstancesResponseErrorType.RateLimited => "rate_limited",
                ListComputeInstancesResponseErrorType.ServerError => "server_error",
                ListComputeInstancesResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListComputeInstancesResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListComputeInstancesResponseErrorType.AuthorizationError,
                "not_found" => ListComputeInstancesResponseErrorType.NotFound,
                "not_implemented" => ListComputeInstancesResponseErrorType.NotImplemented,
                "rate_limited" => ListComputeInstancesResponseErrorType.RateLimited,
                "server_error" => ListComputeInstancesResponseErrorType.ServerError,
                "validation_error" => ListComputeInstancesResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}