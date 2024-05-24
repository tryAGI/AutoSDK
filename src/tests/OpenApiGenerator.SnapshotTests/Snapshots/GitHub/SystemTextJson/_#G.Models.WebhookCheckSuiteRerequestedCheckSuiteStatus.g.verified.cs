//HintName: G.Models.WebhookCheckSuiteRerequestedCheckSuiteStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The summary status for all check runs that are part of the check suite. Can be `requested`, `in_progress`, or `completed`.
    /// </summary>
    public abstract class WebhookCheckSuiteRerequestedCheckSuiteStatus
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Requested = "requested";
        /// <summary>
        /// 
        /// </summary>
        public const string InProgress = "in_progress";
        /// <summary>
        /// 
        /// </summary>
        public const string Completed = "completed";
        /// <summary>
        /// 
        /// </summary>
        public const string Queued = "queued";
    }
}