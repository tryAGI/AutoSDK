//HintName: G.Models.WebhookGollumPagesAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The action that was performed on the page. Can be `created` or `edited`.
    /// </summary>
    public enum WebhookGollumPagesAction
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
    public static class WebhookGollumPagesActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookGollumPagesAction value)
        {
            return value switch
            {
                WebhookGollumPagesAction.Created => "created",
                WebhookGollumPagesAction.Edited => "edited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookGollumPagesAction ToEnum(string value)
        {
            return value switch
            {
                "created" => WebhookGollumPagesAction.Created,
                "edited" => WebhookGollumPagesAction.Edited,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}