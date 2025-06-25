﻿//HintName: G.Models.WebhookPullRequestReviewSubmittedPullRequestAutoMergeMergeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The merge method to use.
    /// </summary>
    public enum WebhookPullRequestReviewSubmittedPullRequestAutoMergeMergeMethod
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
    public static class WebhookPullRequestReviewSubmittedPullRequestAutoMergeMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewSubmittedPullRequestAutoMergeMergeMethod value)
        {
            return value switch
            {
                WebhookPullRequestReviewSubmittedPullRequestAutoMergeMergeMethod.Merge => "merge",
                WebhookPullRequestReviewSubmittedPullRequestAutoMergeMergeMethod.Squash => "squash",
                WebhookPullRequestReviewSubmittedPullRequestAutoMergeMergeMethod.Rebase => "rebase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewSubmittedPullRequestAutoMergeMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "merge" => WebhookPullRequestReviewSubmittedPullRequestAutoMergeMergeMethod.Merge,
                "squash" => WebhookPullRequestReviewSubmittedPullRequestAutoMergeMergeMethod.Squash,
                "rebase" => WebhookPullRequestReviewSubmittedPullRequestAutoMergeMergeMethod.Rebase,
                _ => null,
            };
        }
    }
}