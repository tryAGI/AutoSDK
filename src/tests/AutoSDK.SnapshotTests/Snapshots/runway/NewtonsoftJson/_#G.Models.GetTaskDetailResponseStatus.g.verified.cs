//HintName: G.Models.GetTaskDetailResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Current status of the task:<br/>
    /// - **PENDING**: The task is waiting in the queue.<br/>
    /// - **THROTTLED**: The task is waiting to be enqueued due to other running jobs.<br/>
    /// - **RUNNING**: The task is currently being processed.<br/>
    /// - **SUCCEEDED**: The task completed successfully.<br/>
    /// - **FAILED**: The task failed.<br/>
    /// - **CANCELLED**: The task was aborted.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetTaskDetailResponseStatus
    {
        /// <summary>
        /// The task is waiting in the queue.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PENDING")]
        PENDING,
        /// <summary>
        /// The task is waiting to be enqueued due to other running jobs.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="THROTTLED")]
        THROTTLED,
        /// <summary>
        /// The task is currently being processed.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RUNNING")]
        RUNNING,
        /// <summary>
        /// The task completed successfully.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SUCCEEDED")]
        SUCCEEDED,
        /// <summary>
        /// The task failed.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAILED")]
        FAILED,
        /// <summary>
        /// The task was aborted.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CANCELLED")]
        CANCELLED,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTaskDetailResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTaskDetailResponseStatus value)
        {
            return value switch
            {
                GetTaskDetailResponseStatus.PENDING => "PENDING",
                GetTaskDetailResponseStatus.THROTTLED => "THROTTLED",
                GetTaskDetailResponseStatus.RUNNING => "RUNNING",
                GetTaskDetailResponseStatus.SUCCEEDED => "SUCCEEDED",
                GetTaskDetailResponseStatus.FAILED => "FAILED",
                GetTaskDetailResponseStatus.CANCELLED => "CANCELLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTaskDetailResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "PENDING" => GetTaskDetailResponseStatus.PENDING,
                "THROTTLED" => GetTaskDetailResponseStatus.THROTTLED,
                "RUNNING" => GetTaskDetailResponseStatus.RUNNING,
                "SUCCEEDED" => GetTaskDetailResponseStatus.SUCCEEDED,
                "FAILED" => GetTaskDetailResponseStatus.FAILED,
                "CANCELLED" => GetTaskDetailResponseStatus.CANCELLED,
                _ => null,
            };
        }
    }
}