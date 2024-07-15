//HintName: G.Models.WebhookDiscussionUnlabeledAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDiscussionUnlabeledAction
    {
        /// <summary>
        /// 
        /// </summary>
        Unlabeled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDiscussionUnlabeledActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDiscussionUnlabeledAction value)
        {
            return value switch
            {
                WebhookDiscussionUnlabeledAction.Unlabeled => "unlabeled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDiscussionUnlabeledAction? ToEnum(string value)
        {
            return value switch
            {
                "unlabeled" => WebhookDiscussionUnlabeledAction.Unlabeled,
                _ => null,
            };
        }
    }
}