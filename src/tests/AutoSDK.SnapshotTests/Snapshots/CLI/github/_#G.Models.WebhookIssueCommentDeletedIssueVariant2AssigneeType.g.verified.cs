﻿//HintName: G.Models.WebhookIssueCommentDeletedIssueVariant2AssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentDeletedIssueVariant2AssigneeType
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
    public static class WebhookIssueCommentDeletedIssueVariant2AssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueVariant2AssigneeType value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueVariant2AssigneeType.Bot => "Bot",
                WebhookIssueCommentDeletedIssueVariant2AssigneeType.User => "User",
                WebhookIssueCommentDeletedIssueVariant2AssigneeType.Organization => "Organization",
                WebhookIssueCommentDeletedIssueVariant2AssigneeType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueVariant2AssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentDeletedIssueVariant2AssigneeType.Bot,
                "User" => WebhookIssueCommentDeletedIssueVariant2AssigneeType.User,
                "Organization" => WebhookIssueCommentDeletedIssueVariant2AssigneeType.Organization,
                "Mannequin" => WebhookIssueCommentDeletedIssueVariant2AssigneeType.Mannequin,
                _ => null,
            };
        }
    }
}