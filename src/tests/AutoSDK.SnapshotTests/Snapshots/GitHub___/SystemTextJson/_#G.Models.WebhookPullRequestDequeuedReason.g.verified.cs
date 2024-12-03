//HintName: G.Models.WebhookPullRequestDequeuedReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestDequeuedReason
    {
        /// <summary>
        /// 
        /// </summary>
        UNKNOWNREMOVALREASON,
        /// <summary>
        /// 
        /// </summary>
        MANUAL,
        /// <summary>
        /// 
        /// </summary>
        MERGE,
        /// <summary>
        /// 
        /// </summary>
        MERGECONFLICT,
        /// <summary>
        /// 
        /// </summary>
        CIFAILURE,
        /// <summary>
        /// 
        /// </summary>
        CITIMEOUT,
        /// <summary>
        /// 
        /// </summary>
        ALREADYMERGED,
        /// <summary>
        /// 
        /// </summary>
        QUEUECLEARED,
        /// <summary>
        /// 
        /// </summary>
        ROLLBACK,
        /// <summary>
        /// 
        /// </summary>
        BRANCHPROTECTIONS,
        /// <summary>
        /// 
        /// </summary>
        GITTREEINVALID,
        /// <summary>
        /// 
        /// </summary>
        INVALIDMERGECOMMIT,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestDequeuedReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestDequeuedReason value)
        {
            return value switch
            {
                WebhookPullRequestDequeuedReason.UNKNOWNREMOVALREASON => "UNKNOWN_REMOVAL_REASON",
                WebhookPullRequestDequeuedReason.MANUAL => "MANUAL",
                WebhookPullRequestDequeuedReason.MERGE => "MERGE",
                WebhookPullRequestDequeuedReason.MERGECONFLICT => "MERGE_CONFLICT",
                WebhookPullRequestDequeuedReason.CIFAILURE => "CI_FAILURE",
                WebhookPullRequestDequeuedReason.CITIMEOUT => "CI_TIMEOUT",
                WebhookPullRequestDequeuedReason.ALREADYMERGED => "ALREADY_MERGED",
                WebhookPullRequestDequeuedReason.QUEUECLEARED => "QUEUE_CLEARED",
                WebhookPullRequestDequeuedReason.ROLLBACK => "ROLL_BACK",
                WebhookPullRequestDequeuedReason.BRANCHPROTECTIONS => "BRANCH_PROTECTIONS",
                WebhookPullRequestDequeuedReason.GITTREEINVALID => "GIT_TREE_INVALID",
                WebhookPullRequestDequeuedReason.INVALIDMERGECOMMIT => "INVALID_MERGE_COMMIT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestDequeuedReason? ToEnum(string value)
        {
            return value switch
            {
                "UNKNOWN_REMOVAL_REASON" => WebhookPullRequestDequeuedReason.UNKNOWNREMOVALREASON,
                "MANUAL" => WebhookPullRequestDequeuedReason.MANUAL,
                "MERGE" => WebhookPullRequestDequeuedReason.MERGE,
                "MERGE_CONFLICT" => WebhookPullRequestDequeuedReason.MERGECONFLICT,
                "CI_FAILURE" => WebhookPullRequestDequeuedReason.CIFAILURE,
                "CI_TIMEOUT" => WebhookPullRequestDequeuedReason.CITIMEOUT,
                "ALREADY_MERGED" => WebhookPullRequestDequeuedReason.ALREADYMERGED,
                "QUEUE_CLEARED" => WebhookPullRequestDequeuedReason.QUEUECLEARED,
                "ROLL_BACK" => WebhookPullRequestDequeuedReason.ROLLBACK,
                "BRANCH_PROTECTIONS" => WebhookPullRequestDequeuedReason.BRANCHPROTECTIONS,
                "GIT_TREE_INVALID" => WebhookPullRequestDequeuedReason.GITTREEINVALID,
                "INVALID_MERGE_COMMIT" => WebhookPullRequestDequeuedReason.INVALIDMERGECOMMIT,
                _ => null,
            };
        }
    }
}