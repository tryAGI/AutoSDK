﻿//HintName: G.Models.WebhookPullRequestUnassignedPullRequestHeadRepoSquashMergeCommitTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit title:<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `COMMIT_OR_PR_TITLE` - default to the commit's title (if only one commit) or the pull request's title (when more than one commit).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestUnassignedPullRequestHeadRepoSquashMergeCommitTitle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PR_TITLE")]
        PRTITLE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMMIT_OR_PR_TITLE")]
        COMMITORPRTITLE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestUnassignedPullRequestHeadRepoSquashMergeCommitTitleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnassignedPullRequestHeadRepoSquashMergeCommitTitle value)
        {
            return value switch
            {
                WebhookPullRequestUnassignedPullRequestHeadRepoSquashMergeCommitTitle.PRTITLE => "PR_TITLE",
                WebhookPullRequestUnassignedPullRequestHeadRepoSquashMergeCommitTitle.COMMITORPRTITLE => "COMMIT_OR_PR_TITLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnassignedPullRequestHeadRepoSquashMergeCommitTitle? ToEnum(string value)
        {
            return value switch
            {
                "PR_TITLE" => WebhookPullRequestUnassignedPullRequestHeadRepoSquashMergeCommitTitle.PRTITLE,
                "COMMIT_OR_PR_TITLE" => WebhookPullRequestUnassignedPullRequestHeadRepoSquashMergeCommitTitle.COMMITORPRTITLE,
                _ => null,
            };
        }
    }
}