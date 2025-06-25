﻿//HintName: G.Models.WebhookPullRequestEnqueuedPullRequestHeadUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestEnqueuedPullRequestHeadUserType
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
    public static class WebhookPullRequestEnqueuedPullRequestHeadUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEnqueuedPullRequestHeadUserType value)
        {
            return value switch
            {
                WebhookPullRequestEnqueuedPullRequestHeadUserType.Bot => "Bot",
                WebhookPullRequestEnqueuedPullRequestHeadUserType.User => "User",
                WebhookPullRequestEnqueuedPullRequestHeadUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestEnqueuedPullRequestHeadUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestEnqueuedPullRequestHeadUserType.Bot,
                "User" => WebhookPullRequestEnqueuedPullRequestHeadUserType.User,
                "Organization" => WebhookPullRequestEnqueuedPullRequestHeadUserType.Organization,
                _ => null,
            };
        }
    }
}