﻿//HintName: G.Models.WebhookPullRequestUnlabeledPullRequestBaseUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnlabeledPullRequestBaseUserType
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
    public static class WebhookPullRequestUnlabeledPullRequestBaseUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlabeledPullRequestBaseUserType value)
        {
            return value switch
            {
                WebhookPullRequestUnlabeledPullRequestBaseUserType.Bot => "Bot",
                WebhookPullRequestUnlabeledPullRequestBaseUserType.User => "User",
                WebhookPullRequestUnlabeledPullRequestBaseUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlabeledPullRequestBaseUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnlabeledPullRequestBaseUserType.Bot,
                "User" => WebhookPullRequestUnlabeledPullRequestBaseUserType.User,
                "Organization" => WebhookPullRequestUnlabeledPullRequestBaseUserType.Organization,
                _ => null,
            };
        }
    }
}