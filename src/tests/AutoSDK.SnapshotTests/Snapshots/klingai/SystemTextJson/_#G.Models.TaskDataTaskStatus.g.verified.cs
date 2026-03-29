//HintName: G.Models.TaskDataTaskStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of the task.
    /// </summary>
    public enum TaskDataTaskStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Submitted,
        /// <summary>
        /// 
        /// </summary>
        Succeed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TaskDataTaskStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TaskDataTaskStatus value)
        {
            return value switch
            {
                TaskDataTaskStatus.Failed => "failed",
                TaskDataTaskStatus.Processing => "processing",
                TaskDataTaskStatus.Submitted => "submitted",
                TaskDataTaskStatus.Succeed => "succeed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TaskDataTaskStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => TaskDataTaskStatus.Failed,
                "processing" => TaskDataTaskStatus.Processing,
                "submitted" => TaskDataTaskStatus.Submitted,
                "succeed" => TaskDataTaskStatus.Succeed,
                _ => null,
            };
        }
    }
}