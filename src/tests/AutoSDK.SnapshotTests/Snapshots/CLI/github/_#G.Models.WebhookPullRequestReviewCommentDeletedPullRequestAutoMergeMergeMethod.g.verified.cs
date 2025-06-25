﻿//HintName: G.Models.WebhookPullRequestReviewCommentDeletedPullRequestAutoMergeMergeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The merge method to use.
    /// </summary>
    public enum WebhookPullRequestReviewCommentDeletedPullRequestAutoMergeMergeMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Merge,
        /// <summary>
        /// 
        /// </summary>
        Squash,
        /// <summary>
        /// 
        /// </summary>
        Rebase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewCommentDeletedPullRequestAutoMergeMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentDeletedPullRequestAutoMergeMergeMethod value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentDeletedPullRequestAutoMergeMergeMethod.Merge => "merge",
                WebhookPullRequestReviewCommentDeletedPullRequestAutoMergeMergeMethod.Squash => "squash",
                WebhookPullRequestReviewCommentDeletedPullRequestAutoMergeMergeMethod.Rebase => "rebase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentDeletedPullRequestAutoMergeMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "merge" => WebhookPullRequestReviewCommentDeletedPullRequestAutoMergeMergeMethod.Merge,
                "squash" => WebhookPullRequestReviewCommentDeletedPullRequestAutoMergeMergeMethod.Squash,
                "rebase" => WebhookPullRequestReviewCommentDeletedPullRequestAutoMergeMergeMethod.Rebase,
                _ => null,
            };
        }
    }
}