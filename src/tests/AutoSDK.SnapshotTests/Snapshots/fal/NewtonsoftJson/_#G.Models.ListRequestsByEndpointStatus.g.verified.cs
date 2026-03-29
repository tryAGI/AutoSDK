//HintName: G.Models.ListRequestsByEndpointStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Filter by request status<br/>
    /// Example: success
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListRequestsByEndpointStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user_error")]
        UserError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListRequestsByEndpointStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRequestsByEndpointStatus value)
        {
            return value switch
            {
                ListRequestsByEndpointStatus.Error => "error",
                ListRequestsByEndpointStatus.Success => "success",
                ListRequestsByEndpointStatus.UserError => "user_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRequestsByEndpointStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListRequestsByEndpointStatus.Error,
                "success" => ListRequestsByEndpointStatus.Success,
                "user_error" => ListRequestsByEndpointStatus.UserError,
                _ => null,
            };
        }
    }
}