﻿//HintName: G.Models.WebhookPullRequestLabeledPullRequestAutoMergeMergeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The merge method to use.
    /// </summary>
    public enum WebhookPullRequestLabeledPullRequestAutoMergeMergeMethod
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
    public static class WebhookPullRequestLabeledPullRequestAutoMergeMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLabeledPullRequestAutoMergeMergeMethod value)
        {
            return value switch
            {
                WebhookPullRequestLabeledPullRequestAutoMergeMergeMethod.Merge => "merge",
                WebhookPullRequestLabeledPullRequestAutoMergeMergeMethod.Squash => "squash",
                WebhookPullRequestLabeledPullRequestAutoMergeMergeMethod.Rebase => "rebase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLabeledPullRequestAutoMergeMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "merge" => WebhookPullRequestLabeledPullRequestAutoMergeMergeMethod.Merge,
                "squash" => WebhookPullRequestLabeledPullRequestAutoMergeMergeMethod.Squash,
                "rebase" => WebhookPullRequestLabeledPullRequestAutoMergeMergeMethod.Rebase,
                _ => null,
            };
        }
    }
}