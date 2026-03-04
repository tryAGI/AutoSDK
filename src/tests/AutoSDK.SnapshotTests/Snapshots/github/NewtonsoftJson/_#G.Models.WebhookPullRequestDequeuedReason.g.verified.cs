//HintName: G.Models.WebhookPullRequestDequeuedReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestDequeuedReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="UNKNOWN_REMOVAL_REASON")]
        UnknownRemovalReason,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MANUAL")]
        Manual,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MERGE")]
        Merge,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MERGE_CONFLICT")]
        MergeConflict,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CI_FAILURE")]
        CiFailure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CI_TIMEOUT")]
        CiTimeout,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ALREADY_MERGED")]
        AlreadyMerged,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="QUEUE_CLEARED")]
        QueueCleared,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ROLL_BACK")]
        RollBack,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BRANCH_PROTECTIONS")]
        BranchProtections,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GIT_TREE_INVALID")]
        GitTreeInvalid,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="INVALID_MERGE_COMMIT")]
        InvalidMergeCommit,
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
                WebhookPullRequestDequeuedReason.UnknownRemovalReason => "UNKNOWN_REMOVAL_REASON",
                WebhookPullRequestDequeuedReason.Manual => "MANUAL",
                WebhookPullRequestDequeuedReason.Merge => "MERGE",
                WebhookPullRequestDequeuedReason.MergeConflict => "MERGE_CONFLICT",
                WebhookPullRequestDequeuedReason.CiFailure => "CI_FAILURE",
                WebhookPullRequestDequeuedReason.CiTimeout => "CI_TIMEOUT",
                WebhookPullRequestDequeuedReason.AlreadyMerged => "ALREADY_MERGED",
                WebhookPullRequestDequeuedReason.QueueCleared => "QUEUE_CLEARED",
                WebhookPullRequestDequeuedReason.RollBack => "ROLL_BACK",
                WebhookPullRequestDequeuedReason.BranchProtections => "BRANCH_PROTECTIONS",
                WebhookPullRequestDequeuedReason.GitTreeInvalid => "GIT_TREE_INVALID",
                WebhookPullRequestDequeuedReason.InvalidMergeCommit => "INVALID_MERGE_COMMIT",
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
                "UNKNOWN_REMOVAL_REASON" => WebhookPullRequestDequeuedReason.UnknownRemovalReason,
                "MANUAL" => WebhookPullRequestDequeuedReason.Manual,
                "MERGE" => WebhookPullRequestDequeuedReason.Merge,
                "MERGE_CONFLICT" => WebhookPullRequestDequeuedReason.MergeConflict,
                "CI_FAILURE" => WebhookPullRequestDequeuedReason.CiFailure,
                "CI_TIMEOUT" => WebhookPullRequestDequeuedReason.CiTimeout,
                "ALREADY_MERGED" => WebhookPullRequestDequeuedReason.AlreadyMerged,
                "QUEUE_CLEARED" => WebhookPullRequestDequeuedReason.QueueCleared,
                "ROLL_BACK" => WebhookPullRequestDequeuedReason.RollBack,
                "BRANCH_PROTECTIONS" => WebhookPullRequestDequeuedReason.BranchProtections,
                "GIT_TREE_INVALID" => WebhookPullRequestDequeuedReason.GitTreeInvalid,
                "INVALID_MERGE_COMMIT" => WebhookPullRequestDequeuedReason.InvalidMergeCommit,
                _ => null,
            };
        }
    }
}