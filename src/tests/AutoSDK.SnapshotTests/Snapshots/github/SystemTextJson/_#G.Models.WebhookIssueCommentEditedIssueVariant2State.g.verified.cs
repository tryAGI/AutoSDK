//HintName: G.Models.WebhookIssueCommentEditedIssueVariant2State.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the issue; either 'open' or 'closed'
    /// </summary>
    public enum WebhookIssueCommentEditedIssueVariant2State
    {
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueCommentEditedIssueVariant2StateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueVariant2State value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueVariant2State.Closed => "closed",
                WebhookIssueCommentEditedIssueVariant2State.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueVariant2State? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookIssueCommentEditedIssueVariant2State.Closed,
                "open" => WebhookIssueCommentEditedIssueVariant2State.Open,
                _ => null,
            };
        }
    }
}