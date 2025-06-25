﻿//HintName: G.Models.WebhookIssuesDemilestonedIssueAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesDemilestonedIssueAssigneeType
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
    public static class WebhookIssuesDemilestonedIssueAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDemilestonedIssueAssigneeType value)
        {
            return value switch
            {
                WebhookIssuesDemilestonedIssueAssigneeType.Bot => "Bot",
                WebhookIssuesDemilestonedIssueAssigneeType.User => "User",
                WebhookIssuesDemilestonedIssueAssigneeType.Organization => "Organization",
                WebhookIssuesDemilestonedIssueAssigneeType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDemilestonedIssueAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesDemilestonedIssueAssigneeType.Bot,
                "User" => WebhookIssuesDemilestonedIssueAssigneeType.User,
                "Organization" => WebhookIssuesDemilestonedIssueAssigneeType.Organization,
                "Mannequin" => WebhookIssuesDemilestonedIssueAssigneeType.Mannequin,
                _ => null,
            };
        }
    }
}