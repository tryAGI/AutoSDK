//HintName: G.Models.WebhookProjectsV2ItemRestoredAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookProjectsV2ItemRestoredAction
    {
        /// <summary>
        /// 
        /// </summary>
        Restored,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookProjectsV2ItemRestoredActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookProjectsV2ItemRestoredAction value)
        {
            return value switch
            {
                WebhookProjectsV2ItemRestoredAction.Restored => "restored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookProjectsV2ItemRestoredAction ToEnum(string value)
        {
            return value switch
            {
                "restored" => WebhookProjectsV2ItemRestoredAction.Restored,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}