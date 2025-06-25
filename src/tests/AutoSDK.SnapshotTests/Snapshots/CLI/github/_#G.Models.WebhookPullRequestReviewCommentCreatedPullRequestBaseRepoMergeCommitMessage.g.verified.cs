﻿//HintName: G.Models.WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoMergeCommitMessage
    {
        /// <summary>
        /// 
        /// </summary>
        PRBODY,
        /// <summary>
        /// 
        /// </summary>
        PRTITLE,
        /// <summary>
        /// 
        /// </summary>
        BLANK,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoMergeCommitMessage.PRBODY => "PR_BODY",
                WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoMergeCommitMessage.PRTITLE => "PR_TITLE",
                WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoMergeCommitMessage.PRBODY,
                "PR_TITLE" => WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoMergeCommitMessage.PRTITLE,
                "BLANK" => WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoMergeCommitMessage.BLANK,
                _ => null,
            };
        }
    }
}