//HintName: G.Models.WebhookDiscussionPinnedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDiscussionPinnedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Pinned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDiscussionPinnedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDiscussionPinnedAction value)
        {
            return value switch
            {
                WebhookDiscussionPinnedAction.Pinned => "pinned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDiscussionPinnedAction ToEnum(string value)
        {
            return value switch
            {
                "pinned" => WebhookDiscussionPinnedAction.Pinned,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}