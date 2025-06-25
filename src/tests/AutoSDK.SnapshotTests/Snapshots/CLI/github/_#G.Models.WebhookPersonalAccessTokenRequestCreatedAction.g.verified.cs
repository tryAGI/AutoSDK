﻿//HintName: G.Models.WebhookPersonalAccessTokenRequestCreatedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPersonalAccessTokenRequestCreatedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPersonalAccessTokenRequestCreatedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPersonalAccessTokenRequestCreatedAction value)
        {
            return value switch
            {
                WebhookPersonalAccessTokenRequestCreatedAction.Created => "created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPersonalAccessTokenRequestCreatedAction? ToEnum(string value)
        {
            return value switch
            {
                "created" => WebhookPersonalAccessTokenRequestCreatedAction.Created,
                _ => null,
            };
        }
    }
}