//HintName: G.Models.TaskStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TaskStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Banned,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TaskStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TaskStatus value)
        {
            return value switch
            {
                TaskStatus.Banned => "banned",
                TaskStatus.Cancelled => "cancelled",
                TaskStatus.Expired => "expired",
                TaskStatus.Failed => "failed",
                TaskStatus.Queued => "queued",
                TaskStatus.Running => "running",
                TaskStatus.Success => "success",
                TaskStatus.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TaskStatus? ToEnum(string value)
        {
            return value switch
            {
                "banned" => TaskStatus.Banned,
                "cancelled" => TaskStatus.Cancelled,
                "expired" => TaskStatus.Expired,
                "failed" => TaskStatus.Failed,
                "queued" => TaskStatus.Queued,
                "running" => TaskStatus.Running,
                "success" => TaskStatus.Success,
                "unknown" => TaskStatus.Unknown,
                _ => null,
            };
        }
    }
}