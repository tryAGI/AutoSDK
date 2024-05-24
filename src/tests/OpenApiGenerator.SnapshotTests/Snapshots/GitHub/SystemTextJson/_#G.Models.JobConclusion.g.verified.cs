//HintName: G.Models.JobConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The outcome of the job.
    /// <br/>Example: success
    /// </summary>
    public abstract class JobConclusion
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Success = "success";
        /// <summary>
        /// 
        /// </summary>
        public const string Failure = "failure";
        /// <summary>
        /// 
        /// </summary>
        public const string Neutral = "neutral";
        /// <summary>
        /// 
        /// </summary>
        public const string Cancelled = "cancelled";
        /// <summary>
        /// 
        /// </summary>
        public const string Skipped = "skipped";
        /// <summary>
        /// 
        /// </summary>
        public const string TimedOut = "timed_out";
        /// <summary>
        /// 
        /// </summary>
        public const string ActionRequired = "action_required";
    }
}