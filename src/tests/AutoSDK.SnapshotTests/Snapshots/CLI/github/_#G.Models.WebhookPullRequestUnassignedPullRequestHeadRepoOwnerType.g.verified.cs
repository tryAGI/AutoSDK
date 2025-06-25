﻿//HintName: G.Models.WebhookPullRequestUnassignedPullRequestHeadRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnassignedPullRequestHeadRepoOwnerType
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
    public static class WebhookPullRequestUnassignedPullRequestHeadRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnassignedPullRequestHeadRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestUnassignedPullRequestHeadRepoOwnerType.Bot => "Bot",
                WebhookPullRequestUnassignedPullRequestHeadRepoOwnerType.User => "User",
                WebhookPullRequestUnassignedPullRequestHeadRepoOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnassignedPullRequestHeadRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnassignedPullRequestHeadRepoOwnerType.Bot,
                "User" => WebhookPullRequestUnassignedPullRequestHeadRepoOwnerType.User,
                "Organization" => WebhookPullRequestUnassignedPullRequestHeadRepoOwnerType.Organization,
                _ => null,
            };
        }
    }
}