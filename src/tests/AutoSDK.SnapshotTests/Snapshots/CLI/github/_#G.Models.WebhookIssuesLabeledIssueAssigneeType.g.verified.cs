﻿//HintName: G.Models.WebhookIssuesLabeledIssueAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesLabeledIssueAssigneeType
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
    public static class WebhookIssuesLabeledIssueAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLabeledIssueAssigneeType value)
        {
            return value switch
            {
                WebhookIssuesLabeledIssueAssigneeType.Bot => "Bot",
                WebhookIssuesLabeledIssueAssigneeType.User => "User",
                WebhookIssuesLabeledIssueAssigneeType.Organization => "Organization",
                WebhookIssuesLabeledIssueAssigneeType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLabeledIssueAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesLabeledIssueAssigneeType.Bot,
                "User" => WebhookIssuesLabeledIssueAssigneeType.User,
                "Organization" => WebhookIssuesLabeledIssueAssigneeType.Organization,
                "Mannequin" => WebhookIssuesLabeledIssueAssigneeType.Mannequin,
                _ => null,
            };
        }
    }
}