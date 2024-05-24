//HintName: G.Models.WebhookDeploymentStatusCreatedCheckRunConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result of the completed check run. This value will be `null` until the check run has completed.
    /// </summary>
    public abstract class WebhookDeploymentStatusCreatedCheckRunConclusion
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
        public const string TimedOut = "timed_out";
        /// <summary>
        /// 
        /// </summary>
        public const string ActionRequired = "action_required";
        /// <summary>
        /// 
        /// </summary>
        public const string Stale = "stale";
        /// <summary>
        /// 
        /// </summary>
        public const string Skipped = "skipped";
    }
}