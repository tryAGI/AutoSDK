//HintName: G.Models.BatchStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the batch.
    /// </summary>
    public abstract class BatchStatus
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Validating = "validating";
        /// <summary>
        /// 
        /// </summary>
        public const string Failed = "failed";
        /// <summary>
        /// 
        /// </summary>
        public const string InProgress = "in_progress";
        /// <summary>
        /// 
        /// </summary>
        public const string Finalizing = "finalizing";
        /// <summary>
        /// 
        /// </summary>
        public const string Completed = "completed";
        /// <summary>
        /// 
        /// </summary>
        public const string Expired = "expired";
        /// <summary>
        /// 
        /// </summary>
        public const string Cancelling = "cancelling";
        /// <summary>
        /// 
        /// </summary>
        public const string Cancelled = "cancelled";
    }
}