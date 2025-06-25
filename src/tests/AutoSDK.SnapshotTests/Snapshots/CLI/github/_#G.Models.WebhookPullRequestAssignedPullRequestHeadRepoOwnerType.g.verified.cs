﻿//HintName: G.Models.WebhookPullRequestAssignedPullRequestHeadRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAssignedPullRequestHeadRepoOwnerType
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
    public static class WebhookPullRequestAssignedPullRequestHeadRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAssignedPullRequestHeadRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestAssignedPullRequestHeadRepoOwnerType.Bot => "Bot",
                WebhookPullRequestAssignedPullRequestHeadRepoOwnerType.User => "User",
                WebhookPullRequestAssignedPullRequestHeadRepoOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAssignedPullRequestHeadRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAssignedPullRequestHeadRepoOwnerType.Bot,
                "User" => WebhookPullRequestAssignedPullRequestHeadRepoOwnerType.User,
                "Organization" => WebhookPullRequestAssignedPullRequestHeadRepoOwnerType.Organization,
                _ => null,
            };
        }
    }
}