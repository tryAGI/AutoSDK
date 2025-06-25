﻿//HintName: G.Models.WebhookPullRequestReviewCommentEditedPullRequestBaseRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentEditedPullRequestBaseRepoOwnerType
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
    public static class WebhookPullRequestReviewCommentEditedPullRequestBaseRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentEditedPullRequestBaseRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentEditedPullRequestBaseRepoOwnerType.Bot => "Bot",
                WebhookPullRequestReviewCommentEditedPullRequestBaseRepoOwnerType.User => "User",
                WebhookPullRequestReviewCommentEditedPullRequestBaseRepoOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentEditedPullRequestBaseRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentEditedPullRequestBaseRepoOwnerType.Bot,
                "User" => WebhookPullRequestReviewCommentEditedPullRequestBaseRepoOwnerType.User,
                "Organization" => WebhookPullRequestReviewCommentEditedPullRequestBaseRepoOwnerType.Organization,
                _ => null,
            };
        }
    }
}