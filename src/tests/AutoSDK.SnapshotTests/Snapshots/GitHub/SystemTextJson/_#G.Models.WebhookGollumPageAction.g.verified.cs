//HintName: G.Models.WebhookGollumPageAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The action that was performed on the page. Can be `created` or `edited`.
    /// </summary>
    public enum WebhookGollumPageAction
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Edited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookGollumPageActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookGollumPageAction value)
        {
            return value switch
            {
                WebhookGollumPageAction.Created => "created",
                WebhookGollumPageAction.Edited => "edited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookGollumPageAction? ToEnum(string value)
        {
            return value switch
            {
                "created" => WebhookGollumPageAction.Created,
                "edited" => WebhookGollumPageAction.Edited,
                _ => null,
            };
        }
    }
}