//HintName: G.Models.BatchCallStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BatchCallStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchCallStatus value)
        {
            return value switch
            {
                BatchCallStatus.Pending => "pending",
                BatchCallStatus.InProgress => "in_progress",
                BatchCallStatus.Completed => "completed",
                BatchCallStatus.Failed => "failed",
                BatchCallStatus.Cancelled => "cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "pending" => BatchCallStatus.Pending,
                "in_progress" => BatchCallStatus.InProgress,
                "completed" => BatchCallStatus.Completed,
                "failed" => BatchCallStatus.Failed,
                "cancelled" => BatchCallStatus.Cancelled,
                _ => null,
            };
        }
    }
}