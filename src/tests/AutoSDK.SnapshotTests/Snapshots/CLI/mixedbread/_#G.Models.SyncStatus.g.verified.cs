//HintName: G.Models.SyncStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SyncStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Idle,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
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