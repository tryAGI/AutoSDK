//HintName: G.Models.SyncStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SyncStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
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
        [global::System.Runtime.Serialization.EnumMember(Value="idle")]
        Idle,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SyncStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SyncStatus value)
        {
            return value switch
            {
                SyncStatus.Cancelled => "cancelled",
                SyncStatus.Completed => "completed",
                SyncStatus.Failed => "failed",
                SyncStatus.Idle => "idle",
                SyncStatus.InProgress => "in_progress",
                SyncStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SyncStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => SyncStatus.Cancelled,
                "completed" => SyncStatus.Completed,
                "failed" => SyncStatus.Failed,
                "idle" => SyncStatus.Idle,
                "in_progress" => SyncStatus.InProgress,
                "pending" => SyncStatus.Pending,
                _ => null,
            };
        }
    }
}