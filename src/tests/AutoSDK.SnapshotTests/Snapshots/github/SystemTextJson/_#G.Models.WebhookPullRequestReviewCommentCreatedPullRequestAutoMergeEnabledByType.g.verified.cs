﻿//HintName: G.Models.WebhookPullRequestReviewCommentCreatedPullRequestAutoMergeEnabledByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentCreatedPullRequestAutoMergeEnabledByType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Organization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewCommentCreatedPullRequestAutoMergeEnabledByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedPullRequestAutoMergeEnabledByType value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedPullRequestAutoMergeEnabledByType.Bot => "Bot",
                WebhookPullRequestReviewCommentCreatedPullRequestAutoMergeEnabledByType.User => "User",
                WebhookPullRequestReviewCommentCreatedPullRequestAutoMergeEnabledByType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedPullRequestAutoMergeEnabledByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentCreatedPullRequestAutoMergeEnabledByType.Bot,
                "User" => WebhookPullRequestReviewCommentCreatedPullRequestAutoMergeEnabledByType.User,
                "Organization" => WebhookPullRequestReviewCommentCreatedPullRequestAutoMergeEnabledByType.Organization,
                _ => null,
            };
        }
    }
}