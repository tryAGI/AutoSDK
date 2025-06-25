﻿//HintName: G.Models.WebhookIssueCommentDeletedIssueVariant1UserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentDeletedIssueVariant1UserType
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
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueCommentDeletedIssueVariant1UserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueVariant1UserType value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueVariant1UserType.Bot => "Bot",
                WebhookIssueCommentDeletedIssueVariant1UserType.User => "User",
                WebhookIssueCommentDeletedIssueVariant1UserType.Organization => "Organization",
                WebhookIssueCommentDeletedIssueVariant1UserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueVariant1UserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentDeletedIssueVariant1UserType.Bot,
                "User" => WebhookIssueCommentDeletedIssueVariant1UserType.User,
                "Organization" => WebhookIssueCommentDeletedIssueVariant1UserType.Organization,
                "Mannequin" => WebhookIssueCommentDeletedIssueVariant1UserType.Mannequin,
                _ => null,
            };
        }
    }
}