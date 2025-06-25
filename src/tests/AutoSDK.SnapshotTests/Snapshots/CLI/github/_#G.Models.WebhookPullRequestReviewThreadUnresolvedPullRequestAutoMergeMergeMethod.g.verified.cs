﻿//HintName: G.Models.WebhookPullRequestReviewThreadUnresolvedPullRequestAutoMergeMergeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The merge method to use.
    /// </summary>
    public enum WebhookPullRequestReviewThreadUnresolvedPullRequestAutoMergeMergeMethod
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
    public static class WebhookPullRequestReviewThreadUnresolvedPullRequestAutoMergeMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadUnresolvedPullRequestAutoMergeMergeMethod value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadUnresolvedPullRequestAutoMergeMergeMethod.Merge => "merge",
                WebhookPullRequestReviewThreadUnresolvedPullRequestAutoMergeMergeMethod.Squash => "squash",
                WebhookPullRequestReviewThreadUnresolvedPullRequestAutoMergeMergeMethod.Rebase => "rebase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadUnresolvedPullRequestAutoMergeMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "merge" => WebhookPullRequestReviewThreadUnresolvedPullRequestAutoMergeMergeMethod.Merge,
                "squash" => WebhookPullRequestReviewThreadUnresolvedPullRequestAutoMergeMergeMethod.Squash,
                "rebase" => WebhookPullRequestReviewThreadUnresolvedPullRequestAutoMergeMergeMethod.Rebase,
                _ => null,
            };
        }
    }
}