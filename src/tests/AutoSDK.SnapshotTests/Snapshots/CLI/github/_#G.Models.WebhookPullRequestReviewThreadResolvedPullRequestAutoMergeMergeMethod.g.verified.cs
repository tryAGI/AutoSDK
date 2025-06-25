﻿//HintName: G.Models.WebhookPullRequestReviewThreadResolvedPullRequestAutoMergeMergeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The merge method to use.
    /// </summary>
    public enum WebhookPullRequestReviewThreadResolvedPullRequestAutoMergeMergeMethod
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
    public static class WebhookPullRequestReviewThreadResolvedPullRequestAutoMergeMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedPullRequestAutoMergeMergeMethod value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedPullRequestAutoMergeMergeMethod.Merge => "merge",
                WebhookPullRequestReviewThreadResolvedPullRequestAutoMergeMergeMethod.Squash => "squash",
                WebhookPullRequestReviewThreadResolvedPullRequestAutoMergeMergeMethod.Rebase => "rebase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedPullRequestAutoMergeMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "merge" => WebhookPullRequestReviewThreadResolvedPullRequestAutoMergeMergeMethod.Merge,
                "squash" => WebhookPullRequestReviewThreadResolvedPullRequestAutoMergeMergeMethod.Squash,
                "rebase" => WebhookPullRequestReviewThreadResolvedPullRequestAutoMergeMergeMethod.Rebase,
                _ => null,
            };
        }
    }
}