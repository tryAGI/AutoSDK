﻿//HintName: G.Models.WebhookIssueCommentEditedIssueVariant1AssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentEditedIssueVariant1AssigneeType
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
    public static class WebhookIssueCommentEditedIssueVariant1AssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueVariant1AssigneeType value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueVariant1AssigneeType.Bot => "Bot",
                WebhookIssueCommentEditedIssueVariant1AssigneeType.User => "User",
                WebhookIssueCommentEditedIssueVariant1AssigneeType.Organization => "Organization",
                WebhookIssueCommentEditedIssueVariant1AssigneeType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueVariant1AssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentEditedIssueVariant1AssigneeType.Bot,
                "User" => WebhookIssueCommentEditedIssueVariant1AssigneeType.User,
                "Organization" => WebhookIssueCommentEditedIssueVariant1AssigneeType.Organization,
                "Mannequin" => WebhookIssueCommentEditedIssueVariant1AssigneeType.Mannequin,
                _ => null,
            };
        }
    }
}