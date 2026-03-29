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
        Failed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Successful,
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
                TaskStatus.Failed => "failed",
                TaskStatus.InProgress => "in_progress",
                TaskStatus.Successful => "successful",
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
                "failed" => TaskStatus.Failed,
                "in_progress" => TaskStatus.InProgress,
                "successful" => TaskStatus.Successful,
                _ => null,
            };
        }
    }
}