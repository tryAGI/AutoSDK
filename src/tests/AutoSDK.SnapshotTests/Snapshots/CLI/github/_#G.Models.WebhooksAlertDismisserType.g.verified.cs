﻿//HintName: G.Models.WebhooksAlertDismisserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksAlertDismisserType
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
    public static class WebhooksAlertDismisserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksAlertDismisserType value)
        {
            return value switch
            {
                WebhooksAlertDismisserType.Bot => "Bot",
                WebhooksAlertDismisserType.User => "User",
                WebhooksAlertDismisserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksAlertDismisserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksAlertDismisserType.Bot,
                "User" => WebhooksAlertDismisserType.User,
                "Organization" => WebhooksAlertDismisserType.Organization,
                _ => null,
            };
        }
    }
}