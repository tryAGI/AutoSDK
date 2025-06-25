﻿//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequestHeadUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAutoMergeEnabledPullRequestHeadUserType
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
    public static class WebhookPullRequestAutoMergeEnabledPullRequestHeadUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeEnabledPullRequestHeadUserType value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeEnabledPullRequestHeadUserType.Bot => "Bot",
                WebhookPullRequestAutoMergeEnabledPullRequestHeadUserType.User => "User",
                WebhookPullRequestAutoMergeEnabledPullRequestHeadUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeEnabledPullRequestHeadUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAutoMergeEnabledPullRequestHeadUserType.Bot,
                "User" => WebhookPullRequestAutoMergeEnabledPullRequestHeadUserType.User,
                "Organization" => WebhookPullRequestAutoMergeEnabledPullRequestHeadUserType.Organization,
                _ => null,
            };
        }
    }
}