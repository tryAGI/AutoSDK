﻿//HintName: G.Models.WebhookPullRequestUnlabeledPullRequestHeadRepoMergeCommitTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message title.
    /// </summary>
    public enum WebhookPullRequestUnlabeledPullRequestHeadRepoMergeCommitTitle
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
    public static class WebhookPullRequestUnlabeledPullRequestHeadRepoMergeCommitTitleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlabeledPullRequestHeadRepoMergeCommitTitle value)
        {
            return value switch
            {
                WebhookPullRequestUnlabeledPullRequestHeadRepoMergeCommitTitle.PRTITLE => "PR_TITLE",
                WebhookPullRequestUnlabeledPullRequestHeadRepoMergeCommitTitle.MERGEMESSAGE => "MERGE_MESSAGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlabeledPullRequestHeadRepoMergeCommitTitle? ToEnum(string value)
        {
            return value switch
            {
                "PR_TITLE" => WebhookPullRequestUnlabeledPullRequestHeadRepoMergeCommitTitle.PRTITLE,
                "MERGE_MESSAGE" => WebhookPullRequestUnlabeledPullRequestHeadRepoMergeCommitTitle.MERGEMESSAGE,
                _ => null,
            };
        }
    }
}