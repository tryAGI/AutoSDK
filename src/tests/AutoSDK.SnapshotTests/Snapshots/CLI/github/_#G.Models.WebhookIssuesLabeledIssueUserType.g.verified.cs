﻿//HintName: G.Models.WebhookIssuesLabeledIssueUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesLabeledIssueUserType
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
    public static class WebhookIssuesLabeledIssueUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLabeledIssueUserType value)
        {
            return value switch
            {
                WebhookIssuesLabeledIssueUserType.Bot => "Bot",
                WebhookIssuesLabeledIssueUserType.User => "User",
                WebhookIssuesLabeledIssueUserType.Organization => "Organization",
                WebhookIssuesLabeledIssueUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLabeledIssueUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesLabeledIssueUserType.Bot,
                "User" => WebhookIssuesLabeledIssueUserType.User,
                "Organization" => WebhookIssuesLabeledIssueUserType.Organization,
                "Mannequin" => WebhookIssuesLabeledIssueUserType.Mannequin,
                _ => null,
            };
        }
    }
}