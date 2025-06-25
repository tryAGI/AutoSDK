﻿//HintName: G.Models.WebhookPullRequestLockedPullRequestHeadRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestLockedPullRequestHeadRepoOwnerType
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
    public static class WebhookPullRequestLockedPullRequestHeadRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLockedPullRequestHeadRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestLockedPullRequestHeadRepoOwnerType.Bot => "Bot",
                WebhookPullRequestLockedPullRequestHeadRepoOwnerType.User => "User",
                WebhookPullRequestLockedPullRequestHeadRepoOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLockedPullRequestHeadRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestLockedPullRequestHeadRepoOwnerType.Bot,
                "User" => WebhookPullRequestLockedPullRequestHeadRepoOwnerType.User,
                "Organization" => WebhookPullRequestLockedPullRequestHeadRepoOwnerType.Organization,
                _ => null,
            };
        }
    }
}