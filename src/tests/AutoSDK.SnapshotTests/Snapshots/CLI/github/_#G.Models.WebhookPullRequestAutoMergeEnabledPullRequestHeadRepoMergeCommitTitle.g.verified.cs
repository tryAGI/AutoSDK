﻿//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoMergeCommitTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit title.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., Merge pull request #123 from branch-name).
    /// </summary>
    public enum WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoMergeCommitTitle
    {
        /// <summary>
        /// 
        /// </summary>
        PRTITLE,
        /// <summary>
        /// 
        /// </summary>
        MERGEMESSAGE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoMergeCommitTitleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoMergeCommitTitle value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoMergeCommitTitle.PRTITLE => "PR_TITLE",
                WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoMergeCommitTitle.MERGEMESSAGE => "MERGE_MESSAGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoMergeCommitTitle? ToEnum(string value)
        {
            return value switch
            {
                "PR_TITLE" => WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoMergeCommitTitle.PRTITLE,
                "MERGE_MESSAGE" => WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoMergeCommitTitle.MERGEMESSAGE,
                _ => null,
            };
        }
    }
}