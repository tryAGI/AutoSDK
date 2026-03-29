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
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
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
                TaskStatus.Canceled => "CANCELED",
                TaskStatus.Failed => "FAILED",
                TaskStatus.InProgress => "IN_PROGRESS",
                TaskStatus.Pending => "PENDING",
                TaskStatus.Succeeded => "SUCCEEDED",
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
                "CANCELED" => TaskStatus.Canceled,
                "FAILED" => TaskStatus.Failed,
                "IN_PROGRESS" => TaskStatus.InProgress,
                "PENDING" => TaskStatus.Pending,
                "SUCCEEDED" => TaskStatus.Succeeded,
                _ => null,
            };
        }
    }
}