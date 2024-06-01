//HintName: G.Models.WebhookDiscussionEditedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDiscussionEditedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Edited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDiscussionEditedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDiscussionEditedAction value)
        {
            return value switch
            {
                WebhookDiscussionEditedAction.Edited => "edited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDiscussionEditedAction ToEnum(string value)
        {
            return value switch
            {
                "edited" => WebhookDiscussionEditedAction.Edited,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}