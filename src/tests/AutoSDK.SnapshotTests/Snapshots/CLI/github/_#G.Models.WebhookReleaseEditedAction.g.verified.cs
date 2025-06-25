//HintName: G.Models.WebhookReleaseEditedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookReleaseEditedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Edited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookReleaseEditedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookReleaseEditedAction value)
        {
            return value switch
            {
                WebhookReleaseEditedAction.Edited => "edited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookReleaseEditedAction? ToEnum(string value)
        {
            return value switch
            {
                "edited" => WebhookReleaseEditedAction.Edited,
                _ => null,
            };
        }
    }
}