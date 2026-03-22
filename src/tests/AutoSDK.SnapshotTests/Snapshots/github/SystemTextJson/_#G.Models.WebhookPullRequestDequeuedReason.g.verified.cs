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
        AlreadyMerged,
        /// <summary>
        /// 
        /// </summary>
        BranchProtections,
        /// <summary>
        /// 
        /// </summary>
        CiFailure,
        /// <summary>
        /// 
        /// </summary>
        CiTimeout,
        /// <summary>
        /// 
        /// </summary>
        GitTreeInvalid,
        /// <summary>
        /// 
        /// </summary>
        InvalidMergeCommit,
        /// <summary>
        /// 
        /// </summary>
        Manual,
        /// <summary>
        /// 
        /// </summary>
        Merge,
        /// <summary>
        /// 
        /// </summary>
        MergeConflict,
        /// <summary>
        /// 
        /// </summary>
        QueueCleared,
        /// <summary>
        /// 
        /// </summary>
        RollBack,
        /// <summary>
        /// 
        /// </summary>
        UnknownRemovalReason,
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
                WebhookPullRequestDequeuedReason.AlreadyMerged => "ALREADY_MERGED",
                WebhookPullRequestDequeuedReason.BranchProtections => "BRANCH_PROTECTIONS",
                WebhookPullRequestDequeuedReason.CiFailure => "CI_FAILURE",
                WebhookPullRequestDequeuedReason.CiTimeout => "CI_TIMEOUT",
                WebhookPullRequestDequeuedReason.GitTreeInvalid => "GIT_TREE_INVALID",
                WebhookPullRequestDequeuedReason.InvalidMergeCommit => "INVALID_MERGE_COMMIT",
                WebhookPullRequestDequeuedReason.Manual => "MANUAL",
                WebhookPullRequestDequeuedReason.Merge => "MERGE",
                WebhookPullRequestDequeuedReason.MergeConflict => "MERGE_CONFLICT",
                WebhookPullRequestDequeuedReason.QueueCleared => "QUEUE_CLEARED",
                WebhookPullRequestDequeuedReason.RollBack => "ROLL_BACK",
                WebhookPullRequestDequeuedReason.UnknownRemovalReason => "UNKNOWN_REMOVAL_REASON",
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
                "ALREADY_MERGED" => WebhookPullRequestDequeuedReason.AlreadyMerged,
                "BRANCH_PROTECTIONS" => WebhookPullRequestDequeuedReason.BranchProtections,
                "CI_FAILURE" => WebhookPullRequestDequeuedReason.CiFailure,
                "CI_TIMEOUT" => WebhookPullRequestDequeuedReason.CiTimeout,
                "GIT_TREE_INVALID" => WebhookPullRequestDequeuedReason.GitTreeInvalid,
                "INVALID_MERGE_COMMIT" => WebhookPullRequestDequeuedReason.InvalidMergeCommit,
                "MANUAL" => WebhookPullRequestDequeuedReason.Manual,
                "MERGE" => WebhookPullRequestDequeuedReason.Merge,
                "MERGE_CONFLICT" => WebhookPullRequestDequeuedReason.MergeConflict,
                "QUEUE_CLEARED" => WebhookPullRequestDequeuedReason.QueueCleared,
                "ROLL_BACK" => WebhookPullRequestDequeuedReason.RollBack,
                "UNKNOWN_REMOVAL_REASON" => WebhookPullRequestDequeuedReason.UnknownRemovalReason,
                _ => null,
            };
        }
    }
}