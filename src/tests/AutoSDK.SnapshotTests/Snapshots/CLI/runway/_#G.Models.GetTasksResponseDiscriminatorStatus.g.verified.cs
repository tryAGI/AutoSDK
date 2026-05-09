//HintName: G.Models.GetTasksResponseDiscriminatorStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetTasksResponseDiscriminatorStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
        /// <summary>
        /// 
        /// </summary>
        Throttled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTasksResponseDiscriminatorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTasksResponseDiscriminatorStatus value)
        {
            return value switch
            {
                GetTasksResponseDiscriminatorStatus.Cancelled => "CANCELLED",
                GetTasksResponseDiscriminatorStatus.Failed => "FAILED",
                GetTasksResponseDiscriminatorStatus.Pending => "PENDING",
                GetTasksResponseDiscriminatorStatus.Running => "RUNNING",
                GetTasksResponseDiscriminatorStatus.Succeeded => "SUCCEEDED",
                GetTasksResponseDiscriminatorStatus.Throttled => "THROTTLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTasksResponseDiscriminatorStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => GetTasksResponseDiscriminatorStatus.Cancelled,
                "FAILED" => GetTasksResponseDiscriminatorStatus.Failed,
                "PENDING" => GetTasksResponseDiscriminatorStatus.Pending,
                "RUNNING" => GetTasksResponseDiscriminatorStatus.Running,
                "SUCCEEDED" => GetTasksResponseDiscriminatorStatus.Succeeded,
                "THROTTLED" => GetTasksResponseDiscriminatorStatus.Throttled,
                _ => null,
            };
        }
    }
}