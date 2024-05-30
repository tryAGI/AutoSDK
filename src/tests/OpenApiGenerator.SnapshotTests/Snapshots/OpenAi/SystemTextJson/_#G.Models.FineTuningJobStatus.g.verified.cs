//HintName: G.Models.FineTuningJobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the fine-tuning job, which can be either `validating_files`, `queued`, `running`, `succeeded`, `failed`, or `cancelled`.
    /// </summary>
    public enum FineTuningJobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        ValidatingFiles,
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
        Succeeded,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuningJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuningJobStatus value)
        {
            return value switch
            {
                FineTuningJobStatus.ValidatingFiles => "validating_files",
                FineTuningJobStatus.Queued => "queued",
                FineTuningJobStatus.Running => "running",
                FineTuningJobStatus.Succeeded => "succeeded",
                FineTuningJobStatus.Failed => "failed",
                FineTuningJobStatus.Cancelled => "cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuningJobStatus ToEnum(string value)
        {
            return value switch
            {
                "validating_files" => FineTuningJobStatus.ValidatingFiles,
                "queued" => FineTuningJobStatus.Queued,
                "running" => FineTuningJobStatus.Running,
                "succeeded" => FineTuningJobStatus.Succeeded,
                "failed" => FineTuningJobStatus.Failed,
                "cancelled" => FineTuningJobStatus.Cancelled,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}