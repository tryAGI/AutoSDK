//HintName: G.Models.WebhookCheckSuiteRerequestedCheckSuiteConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The summary conclusion for all check runs that are part of the check suite. This value will be `null` until the check run has completed.
    /// </summary>
    public abstract class WebhookCheckSuiteRerequestedCheckSuiteConclusion
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
    }
}