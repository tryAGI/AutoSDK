//HintName: G.Models.WebhookProjectsV2ItemConvertedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookProjectsV2ItemConvertedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Converted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookProjectsV2ItemConvertedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookProjectsV2ItemConvertedAction value)
        {
            return value switch
            {
                WebhookProjectsV2ItemConvertedAction.Converted => "converted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookProjectsV2ItemConvertedAction? ToEnum(string value)
        {
            return value switch
            {
                "converted" => WebhookProjectsV2ItemConvertedAction.Converted,
                _ => null,
            };
        }
    }
}