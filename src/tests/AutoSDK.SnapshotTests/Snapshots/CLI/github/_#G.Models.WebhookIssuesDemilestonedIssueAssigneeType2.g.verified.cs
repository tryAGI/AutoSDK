﻿//HintName: G.Models.WebhookIssuesDemilestonedIssueAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesDemilestonedIssueAssigneeType2
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
    public static class WebhookIssuesDemilestonedIssueAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDemilestonedIssueAssigneeType2 value)
        {
            return value switch
            {
                WebhookIssuesDemilestonedIssueAssigneeType2.Bot => "Bot",
                WebhookIssuesDemilestonedIssueAssigneeType2.User => "User",
                WebhookIssuesDemilestonedIssueAssigneeType2.Organization => "Organization",
                WebhookIssuesDemilestonedIssueAssigneeType2.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDemilestonedIssueAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesDemilestonedIssueAssigneeType2.Bot,
                "User" => WebhookIssuesDemilestonedIssueAssigneeType2.User,
                "Organization" => WebhookIssuesDemilestonedIssueAssigneeType2.Organization,
                "Mannequin" => WebhookIssuesDemilestonedIssueAssigneeType2.Mannequin,
                _ => null,
            };
        }
    }
}