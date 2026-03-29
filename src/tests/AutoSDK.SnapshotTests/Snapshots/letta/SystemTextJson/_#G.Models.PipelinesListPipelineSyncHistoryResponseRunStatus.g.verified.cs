//HintName: G.Models.PipelinesListPipelineSyncHistoryResponseRunStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinesListPipelineSyncHistoryResponseRunStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Canceled,
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
        Running,
        /// <summary>
        /// 
        /// </summary>
        TimedOut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinesListPipelineSyncHistoryResponseRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesListPipelineSyncHistoryResponseRunStatus value)
        {
            return value switch
            {
                PipelinesListPipelineSyncHistoryResponseRunStatus.Canceled => "canceled",
                PipelinesListPipelineSyncHistoryResponseRunStatus.Completed => "completed",
                PipelinesListPipelineSyncHistoryResponseRunStatus.Failed => "failed",
                PipelinesListPipelineSyncHistoryResponseRunStatus.Running => "running",
                PipelinesListPipelineSyncHistoryResponseRunStatus.TimedOut => "timed_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesListPipelineSyncHistoryResponseRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => PipelinesListPipelineSyncHistoryResponseRunStatus.Canceled,
                "completed" => PipelinesListPipelineSyncHistoryResponseRunStatus.Completed,
                "failed" => PipelinesListPipelineSyncHistoryResponseRunStatus.Failed,
                "running" => PipelinesListPipelineSyncHistoryResponseRunStatus.Running,
                "timed_out" => PipelinesListPipelineSyncHistoryResponseRunStatus.TimedOut,
                _ => null,
            };
        }
    }
}