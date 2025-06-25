﻿//HintName: G.Models.WebhookPullRequestLabeledPullRequestHeadUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestLabeledPullRequestHeadUserType
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
    public static class WebhookPullRequestLabeledPullRequestHeadUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLabeledPullRequestHeadUserType value)
        {
            return value switch
            {
                WebhookPullRequestLabeledPullRequestHeadUserType.Bot => "Bot",
                WebhookPullRequestLabeledPullRequestHeadUserType.User => "User",
                WebhookPullRequestLabeledPullRequestHeadUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLabeledPullRequestHeadUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestLabeledPullRequestHeadUserType.Bot,
                "User" => WebhookPullRequestLabeledPullRequestHeadUserType.User,
                "Organization" => WebhookPullRequestLabeledPullRequestHeadUserType.Organization,
                _ => null,
            };
        }
    }
}