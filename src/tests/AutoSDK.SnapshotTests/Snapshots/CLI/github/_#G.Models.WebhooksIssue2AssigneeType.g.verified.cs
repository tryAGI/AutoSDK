﻿//HintName: G.Models.WebhooksIssue2AssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksIssue2AssigneeType
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
    public static class WebhooksIssue2AssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssue2AssigneeType value)
        {
            return value switch
            {
                WebhooksIssue2AssigneeType.Bot => "Bot",
                WebhooksIssue2AssigneeType.User => "User",
                WebhooksIssue2AssigneeType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssue2AssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksIssue2AssigneeType.Bot,
                "User" => WebhooksIssue2AssigneeType.User,
                "Organization" => WebhooksIssue2AssigneeType.Organization,
                _ => null,
            };
        }
    }
}