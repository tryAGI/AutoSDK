//HintName: G.Models.WebhookProjectCardConvertedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookProjectCardConvertedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Converted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookProjectCardConvertedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookProjectCardConvertedAction value)
        {
            return value switch
            {
                WebhookProjectCardConvertedAction.Converted => "converted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookProjectCardConvertedAction? ToEnum(string value)
        {
            return value switch
            {
                "converted" => WebhookProjectCardConvertedAction.Converted,
                _ => null,
            };
        }
    }
}