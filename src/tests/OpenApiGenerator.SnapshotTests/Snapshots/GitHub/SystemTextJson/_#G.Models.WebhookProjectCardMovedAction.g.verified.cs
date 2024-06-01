//HintName: G.Models.WebhookProjectCardMovedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookProjectCardMovedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Moved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookProjectCardMovedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookProjectCardMovedAction value)
        {
            return value switch
            {
                WebhookProjectCardMovedAction.Moved => "moved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookProjectCardMovedAction ToEnum(string value)
        {
            return value switch
            {
                "moved" => WebhookProjectCardMovedAction.Moved,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}