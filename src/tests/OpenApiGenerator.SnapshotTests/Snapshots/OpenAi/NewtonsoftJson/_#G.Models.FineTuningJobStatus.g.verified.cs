//HintName: G.Models.FineTuningJobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the fine-tuning job, which can be either `validating_files`, `queued`, `running`, `succeeded`, `failed`, or `cancelled`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FineTuningJobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="validating_files")]
        ValidatingFiles,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
        Queued,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="running")]
        Running,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="succeeded")]
        Succeeded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
    }

    public static class FineTuningJobStatusExtensions
    {
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
        public static FineTuningJobStatus ToEnum(int value)
        {
            return value switch
            {
                0 => FineTuningJobStatus.ValidatingFiles,
                1 => FineTuningJobStatus.Queued,
                2 => FineTuningJobStatus.Running,
                3 => FineTuningJobStatus.Succeeded,
                4 => FineTuningJobStatus.Failed,
                5 => FineTuningJobStatus.Cancelled,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}