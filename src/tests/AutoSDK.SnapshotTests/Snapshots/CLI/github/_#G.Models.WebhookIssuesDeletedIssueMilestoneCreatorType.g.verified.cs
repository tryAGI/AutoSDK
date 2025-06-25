﻿//HintName: G.Models.WebhookIssuesDeletedIssueMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesDeletedIssueMilestoneCreatorType
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
    public static class WebhookIssuesDeletedIssueMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDeletedIssueMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookIssuesDeletedIssueMilestoneCreatorType.Bot => "Bot",
                WebhookIssuesDeletedIssueMilestoneCreatorType.User => "User",
                WebhookIssuesDeletedIssueMilestoneCreatorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDeletedIssueMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesDeletedIssueMilestoneCreatorType.Bot,
                "User" => WebhookIssuesDeletedIssueMilestoneCreatorType.User,
                "Organization" => WebhookIssuesDeletedIssueMilestoneCreatorType.Organization,
                _ => null,
            };
        }
    }
}