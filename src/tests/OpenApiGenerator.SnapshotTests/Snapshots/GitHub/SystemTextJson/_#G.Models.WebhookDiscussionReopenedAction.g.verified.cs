//HintName: G.Models.WebhookDiscussionReopenedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDiscussionReopenedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Reopened,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDiscussionReopenedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDiscussionReopenedAction value)
        {
            return value switch
            {
                WebhookDiscussionReopenedAction.Reopened => "reopened",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDiscussionReopenedAction ToEnum(string value)
        {
            return value switch
            {
                "reopened" => WebhookDiscussionReopenedAction.Reopened,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}