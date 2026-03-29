//HintName: G.Models.ResponseInputMessageStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of item. Populated when items are returned via API.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseInputMessageStatus
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
        [global::System.Runtime.Serialization.EnumMember(Value="incomplete")]
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseInputMessageStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseInputMessageStatus value)
        {
            return value switch
            {
                ResponseInputMessageStatus.Completed => "completed",
                ResponseInputMessageStatus.InProgress => "in_progress",
                ResponseInputMessageStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseInputMessageStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResponseInputMessageStatus.Completed,
                "in_progress" => ResponseInputMessageStatus.InProgress,
                "incomplete" => ResponseInputMessageStatus.Incomplete,
                _ => null,
            };
        }
    }
}