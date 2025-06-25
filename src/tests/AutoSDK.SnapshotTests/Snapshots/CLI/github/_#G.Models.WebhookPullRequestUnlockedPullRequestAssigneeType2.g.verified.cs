﻿//HintName: G.Models.WebhookPullRequestUnlockedPullRequestAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnlockedPullRequestAssigneeType2
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
    public static class WebhookPullRequestUnlockedPullRequestAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlockedPullRequestAssigneeType2 value)
        {
            return value switch
            {
                WebhookPullRequestUnlockedPullRequestAssigneeType2.Bot => "Bot",
                WebhookPullRequestUnlockedPullRequestAssigneeType2.User => "User",
                WebhookPullRequestUnlockedPullRequestAssigneeType2.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlockedPullRequestAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnlockedPullRequestAssigneeType2.Bot,
                "User" => WebhookPullRequestUnlockedPullRequestAssigneeType2.User,
                "Organization" => WebhookPullRequestUnlockedPullRequestAssigneeType2.Organization,
                _ => null,
            };
        }
    }
}