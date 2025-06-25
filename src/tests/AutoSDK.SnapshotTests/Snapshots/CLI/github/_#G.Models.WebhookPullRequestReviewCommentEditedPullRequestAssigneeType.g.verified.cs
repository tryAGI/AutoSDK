﻿//HintName: G.Models.WebhookPullRequestReviewCommentEditedPullRequestAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentEditedPullRequestAssigneeType
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
    public static class WebhookPullRequestReviewCommentEditedPullRequestAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentEditedPullRequestAssigneeType value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentEditedPullRequestAssigneeType.Bot => "Bot",
                WebhookPullRequestReviewCommentEditedPullRequestAssigneeType.User => "User",
                WebhookPullRequestReviewCommentEditedPullRequestAssigneeType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentEditedPullRequestAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentEditedPullRequestAssigneeType.Bot,
                "User" => WebhookPullRequestReviewCommentEditedPullRequestAssigneeType.User,
                "Organization" => WebhookPullRequestReviewCommentEditedPullRequestAssigneeType.Organization,
                _ => null,
            };
        }
    }
}