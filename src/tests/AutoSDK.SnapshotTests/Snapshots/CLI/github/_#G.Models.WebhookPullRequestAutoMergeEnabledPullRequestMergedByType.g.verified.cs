﻿//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequestMergedByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAutoMergeEnabledPullRequestMergedByType
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
    public static class WebhookPullRequestAutoMergeEnabledPullRequestMergedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeEnabledPullRequestMergedByType value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeEnabledPullRequestMergedByType.Bot => "Bot",
                WebhookPullRequestAutoMergeEnabledPullRequestMergedByType.User => "User",
                WebhookPullRequestAutoMergeEnabledPullRequestMergedByType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeEnabledPullRequestMergedByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAutoMergeEnabledPullRequestMergedByType.Bot,
                "User" => WebhookPullRequestAutoMergeEnabledPullRequestMergedByType.User,
                "Organization" => WebhookPullRequestAutoMergeEnabledPullRequestMergedByType.Organization,
                _ => null,
            };
        }
    }
}