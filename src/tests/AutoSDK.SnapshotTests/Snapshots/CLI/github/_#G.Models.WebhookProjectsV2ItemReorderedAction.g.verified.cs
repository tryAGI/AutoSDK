//HintName: G.Models.WebhookProjectsV2ItemReorderedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookProjectsV2ItemReorderedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Reordered,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookProjectsV2ItemReorderedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookProjectsV2ItemReorderedAction value)
        {
            return value switch
            {
                WebhookProjectsV2ItemReorderedAction.Reordered => "reordered",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookProjectsV2ItemReorderedAction? ToEnum(string value)
        {
            return value switch
            {
                "reordered" => WebhookProjectsV2ItemReorderedAction.Reordered,
                _ => null,
            };
        }
    }
}