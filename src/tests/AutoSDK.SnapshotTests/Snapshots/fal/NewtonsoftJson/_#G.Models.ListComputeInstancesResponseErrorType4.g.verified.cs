//HintName: G.Models.ListComputeInstancesResponseErrorType4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListComputeInstancesResponseErrorType4
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
    public static class ListComputeInstancesResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListComputeInstancesResponseErrorType4 value)
        {
            return value switch
            {
                ListComputeInstancesResponseErrorType4.AuthorizationError => "authorization_error",
                ListComputeInstancesResponseErrorType4.NotFound => "not_found",
                ListComputeInstancesResponseErrorType4.NotImplemented => "not_implemented",
                ListComputeInstancesResponseErrorType4.RateLimited => "rate_limited",
                ListComputeInstancesResponseErrorType4.ServerError => "server_error",
                ListComputeInstancesResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListComputeInstancesResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListComputeInstancesResponseErrorType4.AuthorizationError,
                "not_found" => ListComputeInstancesResponseErrorType4.NotFound,
                "not_implemented" => ListComputeInstancesResponseErrorType4.NotImplemented,
                "rate_limited" => ListComputeInstancesResponseErrorType4.RateLimited,
                "server_error" => ListComputeInstancesResponseErrorType4.ServerError,
                "validation_error" => ListComputeInstancesResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}