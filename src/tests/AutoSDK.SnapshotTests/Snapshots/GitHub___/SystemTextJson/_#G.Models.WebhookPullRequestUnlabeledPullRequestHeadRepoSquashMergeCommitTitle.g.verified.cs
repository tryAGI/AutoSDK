//HintName: G.Models.WebhookPullRequestUnlabeledPullRequestHeadRepoSquashMergeCommitTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit title:<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `COMMIT_OR_PR_TITLE` - default to the commit's title (if only one commit) or the pull request's title (when more than one commit).
    /// </summary>
    public enum WebhookPullRequestUnlabeledPullRequestHeadRepoSquashMergeCommitTitle
    {
        /// <summary>
        /// 
        /// </summary>
        PRTITLE,
        /// <summary>
        /// 
        /// </summary>
        COMMITORPRTITLE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestUnlabeledPullRequestHeadRepoSquashMergeCommitTitleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlabeledPullRequestHeadRepoSquashMergeCommitTitle value)
        {
            return value switch
            {
                WebhookPullRequestUnlabeledPullRequestHeadRepoSquashMergeCommitTitle.PRTITLE => "PR_TITLE",
                WebhookPullRequestUnlabeledPullRequestHeadRepoSquashMergeCommitTitle.COMMITORPRTITLE => "COMMIT_OR_PR_TITLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlabeledPullRequestHeadRepoSquashMergeCommitTitle? ToEnum(string value)
        {
            return value switch
            {
                "PR_TITLE" => WebhookPullRequestUnlabeledPullRequestHeadRepoSquashMergeCommitTitle.PRTITLE,
                "COMMIT_OR_PR_TITLE" => WebhookPullRequestUnlabeledPullRequestHeadRepoSquashMergeCommitTitle.COMMITORPRTITLE,
                _ => null,
            };
        }
    }
}