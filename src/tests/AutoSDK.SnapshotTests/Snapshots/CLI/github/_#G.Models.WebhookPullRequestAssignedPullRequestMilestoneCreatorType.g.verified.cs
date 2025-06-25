﻿//HintName: G.Models.WebhookPullRequestAssignedPullRequestMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAssignedPullRequestMilestoneCreatorType
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
    public static class WebhookPullRequestAssignedPullRequestMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAssignedPullRequestMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookPullRequestAssignedPullRequestMilestoneCreatorType.Bot => "Bot",
                WebhookPullRequestAssignedPullRequestMilestoneCreatorType.User => "User",
                WebhookPullRequestAssignedPullRequestMilestoneCreatorType.Organization => "Organization",
                WebhookPullRequestAssignedPullRequestMilestoneCreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAssignedPullRequestMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAssignedPullRequestMilestoneCreatorType.Bot,
                "User" => WebhookPullRequestAssignedPullRequestMilestoneCreatorType.User,
                "Organization" => WebhookPullRequestAssignedPullRequestMilestoneCreatorType.Organization,
                "Mannequin" => WebhookPullRequestAssignedPullRequestMilestoneCreatorType.Mannequin,
                _ => null,
            };
        }
    }
}