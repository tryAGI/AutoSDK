﻿//HintName: G.Models.WebhookPullRequestSynchronizePullRequestAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestSynchronizePullRequestAssigneeType
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
    public static class WebhookPullRequestSynchronizePullRequestAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestSynchronizePullRequestAssigneeType value)
        {
            return value switch
            {
                WebhookPullRequestSynchronizePullRequestAssigneeType.Bot => "Bot",
                WebhookPullRequestSynchronizePullRequestAssigneeType.User => "User",
                WebhookPullRequestSynchronizePullRequestAssigneeType.Organization => "Organization",
                WebhookPullRequestSynchronizePullRequestAssigneeType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestSynchronizePullRequestAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestSynchronizePullRequestAssigneeType.Bot,
                "User" => WebhookPullRequestSynchronizePullRequestAssigneeType.User,
                "Organization" => WebhookPullRequestSynchronizePullRequestAssigneeType.Organization,
                "Mannequin" => WebhookPullRequestSynchronizePullRequestAssigneeType.Mannequin,
                _ => null,
            };
        }
    }
}