﻿//HintName: G.Models.WebhooksRelease1AuthorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksRelease1AuthorType
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
    public static class WebhooksRelease1AuthorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksRelease1AuthorType value)
        {
            return value switch
            {
                WebhooksRelease1AuthorType.Bot => "Bot",
                WebhooksRelease1AuthorType.User => "User",
                WebhooksRelease1AuthorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksRelease1AuthorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksRelease1AuthorType.Bot,
                "User" => WebhooksRelease1AuthorType.User,
                "Organization" => WebhooksRelease1AuthorType.Organization,
                _ => null,
            };
        }
    }
}