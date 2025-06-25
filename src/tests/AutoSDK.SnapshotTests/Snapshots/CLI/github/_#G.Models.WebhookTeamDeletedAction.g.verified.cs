﻿//HintName: G.Models.WebhookTeamDeletedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookTeamDeletedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Deleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookTeamDeletedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookTeamDeletedAction value)
        {
            return value switch
            {
                WebhookTeamDeletedAction.Deleted => "deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookTeamDeletedAction? ToEnum(string value)
        {
            return value switch
            {
                "deleted" => WebhookTeamDeletedAction.Deleted,
                _ => null,
            };
        }
    }
}