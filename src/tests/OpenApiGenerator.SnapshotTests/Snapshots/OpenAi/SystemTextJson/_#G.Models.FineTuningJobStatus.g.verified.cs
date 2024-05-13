//HintName: G.Models.FineTuningJobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the fine-tuning job, which can be either `validating_files`, `queued`, `running`, `succeeded`, `failed`, or `cancelled`.
    /// </summary>
    public abstract class FineTuningJobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        public const string ValidatingFiles = "validating_files";
        /// <summary>
        /// 
        /// </summary>
        public const string Queued = "queued";
        /// <summary>
        /// 
        /// </summary>
        public const string Running = "running";
        /// <summary>
        /// 
        /// </summary>
        public const string Succeeded = "succeeded";
        /// <summary>
        /// 
        /// </summary>
        public const string Failed = "failed";
        /// <summary>
        /// 
        /// </summary>
        public const string Cancelled = "cancelled";
    }
}