//HintName: G.Models.TaskListDataTaskStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of the task.
    /// </summary>
    public enum TaskListDataTaskStatus
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
    public static class TaskListDataTaskStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TaskListDataTaskStatus value)
        {
            return value switch
            {
                TaskListDataTaskStatus.Failed => "failed",
                TaskListDataTaskStatus.Processing => "processing",
                TaskListDataTaskStatus.Submitted => "submitted",
                TaskListDataTaskStatus.Succeed => "succeed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TaskListDataTaskStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => TaskListDataTaskStatus.Failed,
                "processing" => TaskListDataTaskStatus.Processing,
                "submitted" => TaskListDataTaskStatus.Submitted,
                "succeed" => TaskListDataTaskStatus.Succeed,
                _ => null,
            };
        }
    }
}