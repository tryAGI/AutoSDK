//HintName: G.Models.WebhookReleasePrereleasedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookReleasePrereleasedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Prereleased,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookReleasePrereleasedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookReleasePrereleasedAction value)
        {
            return value switch
            {
                WebhookReleasePrereleasedAction.Prereleased => "prereleased",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookReleasePrereleasedAction? ToEnum(string value)
        {
            return value switch
            {
                "prereleased" => WebhookReleasePrereleasedAction.Prereleased,
                _ => null,
            };
        }
    }
}