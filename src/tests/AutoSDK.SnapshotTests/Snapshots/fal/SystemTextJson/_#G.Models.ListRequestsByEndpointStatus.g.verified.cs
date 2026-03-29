//HintName: G.Models.ListRequestsByEndpointStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Filter by request status<br/>
    /// Example: success
    /// </summary>
    public enum ListRequestsByEndpointStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
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