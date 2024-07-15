//HintName: G.Models.WebhookReleaseReleasedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookReleaseReleasedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Released,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookReleaseReleasedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookReleaseReleasedAction value)
        {
            return value switch
            {
                WebhookReleaseReleasedAction.Released => "released",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookReleaseReleasedAction? ToEnum(string value)
        {
            return value switch
            {
                "released" => WebhookReleaseReleasedAction.Released,
                _ => null,
            };
        }
    }
}