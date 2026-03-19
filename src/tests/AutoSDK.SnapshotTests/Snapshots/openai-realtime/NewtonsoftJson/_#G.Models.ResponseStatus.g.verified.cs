//HintName: G.Models.ResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the response.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="incomplete")]
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseStatus value)
        {
            return value switch
            {
                ResponseStatus.Completed => "completed",
                ResponseStatus.InProgress => "in_progress",
                ResponseStatus.Cancelled => "cancelled",
                ResponseStatus.Failed => "failed",
                ResponseStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResponseStatus.Completed,
                "in_progress" => ResponseStatus.InProgress,
                "cancelled" => ResponseStatus.Cancelled,
                "failed" => ResponseStatus.Failed,
                "incomplete" => ResponseStatus.Incomplete,
                _ => null,
            };
        }
    }
}