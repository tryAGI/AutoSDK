//HintName: G.Models.WebhookDiscussionLabeledAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDiscussionLabeledAction
    {
        /// <summary>
        /// 
        /// </summary>
        Labeled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDiscussionLabeledActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDiscussionLabeledAction value)
        {
            return value switch
            {
                WebhookDiscussionLabeledAction.Labeled => "labeled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDiscussionLabeledAction ToEnum(string value)
        {
            return value switch
            {
                "labeled" => WebhookDiscussionLabeledAction.Labeled,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}