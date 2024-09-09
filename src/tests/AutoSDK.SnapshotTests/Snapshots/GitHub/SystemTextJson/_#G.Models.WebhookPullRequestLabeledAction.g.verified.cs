//HintName: G.Models.WebhookPullRequestLabeledAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestLabeledAction
    {
        /// <summary>
        /// 
        /// </summary>
        Labeled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestLabeledActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLabeledAction value)
        {
            return value switch
            {
                WebhookPullRequestLabeledAction.Labeled => "labeled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLabeledAction? ToEnum(string value)
        {
            return value switch
            {
                "labeled" => WebhookPullRequestLabeledAction.Labeled,
                _ => null,
            };
        }
    }
}