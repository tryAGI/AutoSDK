﻿//HintName: G.Models.WebhookProjectsV2ItemEditedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookProjectsV2ItemEditedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Edited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookProjectsV2ItemEditedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookProjectsV2ItemEditedAction value)
        {
            return value switch
            {
                WebhookProjectsV2ItemEditedAction.Edited => "edited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookProjectsV2ItemEditedAction? ToEnum(string value)
        {
            return value switch
            {
                "edited" => WebhookProjectsV2ItemEditedAction.Edited,
                _ => null,
            };
        }
    }
}