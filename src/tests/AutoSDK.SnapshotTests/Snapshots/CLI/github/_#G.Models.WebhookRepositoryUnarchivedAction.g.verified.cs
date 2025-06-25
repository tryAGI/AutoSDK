﻿//HintName: G.Models.WebhookRepositoryUnarchivedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookRepositoryUnarchivedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Unarchived,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookRepositoryUnarchivedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookRepositoryUnarchivedAction value)
        {
            return value switch
            {
                WebhookRepositoryUnarchivedAction.Unarchived => "unarchived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookRepositoryUnarchivedAction? ToEnum(string value)
        {
            return value switch
            {
                "unarchived" => WebhookRepositoryUnarchivedAction.Unarchived,
                _ => null,
            };
        }
    }
}