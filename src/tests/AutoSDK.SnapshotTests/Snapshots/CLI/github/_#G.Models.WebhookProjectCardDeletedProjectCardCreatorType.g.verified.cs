﻿//HintName: G.Models.WebhookProjectCardDeletedProjectCardCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookProjectCardDeletedProjectCardCreatorType
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
    public static class WebhookProjectCardDeletedProjectCardCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookProjectCardDeletedProjectCardCreatorType value)
        {
            return value switch
            {
                WebhookProjectCardDeletedProjectCardCreatorType.Bot => "Bot",
                WebhookProjectCardDeletedProjectCardCreatorType.User => "User",
                WebhookProjectCardDeletedProjectCardCreatorType.Organization => "Organization",
                WebhookProjectCardDeletedProjectCardCreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookProjectCardDeletedProjectCardCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookProjectCardDeletedProjectCardCreatorType.Bot,
                "User" => WebhookProjectCardDeletedProjectCardCreatorType.User,
                "Organization" => WebhookProjectCardDeletedProjectCardCreatorType.Organization,
                "Mannequin" => WebhookProjectCardDeletedProjectCardCreatorType.Mannequin,
                _ => null,
            };
        }
    }
}