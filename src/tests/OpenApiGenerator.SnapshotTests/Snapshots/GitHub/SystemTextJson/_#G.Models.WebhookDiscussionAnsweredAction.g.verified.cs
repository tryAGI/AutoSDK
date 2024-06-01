//HintName: G.Models.WebhookDiscussionAnsweredAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDiscussionAnsweredAction
    {
        /// <summary>
        /// 
        /// </summary>
        Answered,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDiscussionAnsweredActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDiscussionAnsweredAction value)
        {
            return value switch
            {
                WebhookDiscussionAnsweredAction.Answered => "answered",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDiscussionAnsweredAction ToEnum(string value)
        {
            return value switch
            {
                "answered" => WebhookDiscussionAnsweredAction.Answered,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}