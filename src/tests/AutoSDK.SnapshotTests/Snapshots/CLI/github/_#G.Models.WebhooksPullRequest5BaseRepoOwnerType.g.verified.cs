﻿//HintName: G.Models.WebhooksPullRequest5BaseRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksPullRequest5BaseRepoOwnerType
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
    public static class WebhooksPullRequest5BaseRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5BaseRepoOwnerType value)
        {
            return value switch
            {
                WebhooksPullRequest5BaseRepoOwnerType.Bot => "Bot",
                WebhooksPullRequest5BaseRepoOwnerType.User => "User",
                WebhooksPullRequest5BaseRepoOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5BaseRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksPullRequest5BaseRepoOwnerType.Bot,
                "User" => WebhooksPullRequest5BaseRepoOwnerType.User,
                "Organization" => WebhooksPullRequest5BaseRepoOwnerType.Organization,
                _ => null,
            };
        }
    }
}