//HintName: G.Models.WebhookDiscussionUnansweredAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDiscussionUnansweredAction
    {
        /// <summary>
        /// 
        /// </summary>
        Unanswered,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDiscussionUnansweredActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDiscussionUnansweredAction value)
        {
            return value switch
            {
                WebhookDiscussionUnansweredAction.Unanswered => "unanswered",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDiscussionUnansweredAction ToEnum(string value)
        {
            return value switch
            {
                "unanswered" => WebhookDiscussionUnansweredAction.Unanswered,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}