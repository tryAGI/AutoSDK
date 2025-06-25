﻿//HintName: G.Models.WebhookIssuesUnlockedIssueMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesUnlockedIssueMilestoneCreatorType
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
    public static class WebhookIssuesUnlockedIssueMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesUnlockedIssueMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookIssuesUnlockedIssueMilestoneCreatorType.Bot => "Bot",
                WebhookIssuesUnlockedIssueMilestoneCreatorType.User => "User",
                WebhookIssuesUnlockedIssueMilestoneCreatorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesUnlockedIssueMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesUnlockedIssueMilestoneCreatorType.Bot,
                "User" => WebhookIssuesUnlockedIssueMilestoneCreatorType.User,
                "Organization" => WebhookIssuesUnlockedIssueMilestoneCreatorType.Organization,
                _ => null,
            };
        }
    }
}