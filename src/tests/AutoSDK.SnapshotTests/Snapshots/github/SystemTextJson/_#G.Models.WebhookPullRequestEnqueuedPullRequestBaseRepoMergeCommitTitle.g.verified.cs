//HintName: G.Models.WebhookPullRequestEnqueuedPullRequestBaseRepoMergeCommitTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit title.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., Merge pull request #123 from branch-name).
    /// </summary>
    public enum WebhookPullRequestEnqueuedPullRequestBaseRepoMergeCommitTitle
    {
        /// <summary>
        /// 
        /// </summary>
        PrTitle,
        /// <summary>
        /// 
        /// </summary>
        MergeMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestEnqueuedPullRequestBaseRepoMergeCommitTitleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEnqueuedPullRequestBaseRepoMergeCommitTitle value)
        {
            return value switch
            {
                WebhookPullRequestEnqueuedPullRequestBaseRepoMergeCommitTitle.PrTitle => "PR_TITLE",
                WebhookPullRequestEnqueuedPullRequestBaseRepoMergeCommitTitle.MergeMessage => "MERGE_MESSAGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestEnqueuedPullRequestBaseRepoMergeCommitTitle? ToEnum(string value)
        {
            return value switch
            {
                "PR_TITLE" => WebhookPullRequestEnqueuedPullRequestBaseRepoMergeCommitTitle.PrTitle,
                "MERGE_MESSAGE" => WebhookPullRequestEnqueuedPullRequestBaseRepoMergeCommitTitle.MergeMessage,
                _ => null,
            };
        }
    }
}