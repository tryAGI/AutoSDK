//HintName: G.Models.WebhookDiscussionCommentEditedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDiscussionCommentEditedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Edited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDiscussionCommentEditedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDiscussionCommentEditedAction value)
        {
            return value switch
            {
                WebhookDiscussionCommentEditedAction.Edited => "edited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDiscussionCommentEditedAction? ToEnum(string value)
        {
            return value switch
            {
                "edited" => WebhookDiscussionCommentEditedAction.Edited,
                _ => null,
            };
        }
    }
}