﻿//HintName: G.Models.WebhookPullRequestReviewDismissedPullRequestAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewDismissedPullRequestAssigneeType
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
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewDismissedPullRequestAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewDismissedPullRequestAssigneeType value)
        {
            return value switch
            {
                WebhookPullRequestReviewDismissedPullRequestAssigneeType.Bot => "Bot",
                WebhookPullRequestReviewDismissedPullRequestAssigneeType.User => "User",
                WebhookPullRequestReviewDismissedPullRequestAssigneeType.Organization => "Organization",
                WebhookPullRequestReviewDismissedPullRequestAssigneeType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewDismissedPullRequestAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewDismissedPullRequestAssigneeType.Bot,
                "User" => WebhookPullRequestReviewDismissedPullRequestAssigneeType.User,
                "Organization" => WebhookPullRequestReviewDismissedPullRequestAssigneeType.Organization,
                "Mannequin" => WebhookPullRequestReviewDismissedPullRequestAssigneeType.Mannequin,
                _ => null,
            };
        }
    }
}