﻿//HintName: G.Models.WebhookPullRequestSynchronizePullRequestAutoMergeEnabledByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestSynchronizePullRequestAutoMergeEnabledByType
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
    public static class WebhookPullRequestSynchronizePullRequestAutoMergeEnabledByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestSynchronizePullRequestAutoMergeEnabledByType value)
        {
            return value switch
            {
                WebhookPullRequestSynchronizePullRequestAutoMergeEnabledByType.Bot => "Bot",
                WebhookPullRequestSynchronizePullRequestAutoMergeEnabledByType.User => "User",
                WebhookPullRequestSynchronizePullRequestAutoMergeEnabledByType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestSynchronizePullRequestAutoMergeEnabledByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestSynchronizePullRequestAutoMergeEnabledByType.Bot,
                "User" => WebhookPullRequestSynchronizePullRequestAutoMergeEnabledByType.User,
                "Organization" => WebhookPullRequestSynchronizePullRequestAutoMergeEnabledByType.Organization,
                _ => null,
            };
        }
    }
}