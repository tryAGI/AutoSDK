//HintName: G.Models.WebhookIssueCommentDeletedIssueVariant2State.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the issue; either 'open' or 'closed'
    /// </summary>
    public enum WebhookIssueCommentDeletedIssueVariant2State
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
    public static class WebhookIssueCommentDeletedIssueVariant2StateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueVariant2State value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueVariant2State.Closed => "closed",
                WebhookIssueCommentDeletedIssueVariant2State.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueVariant2State? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookIssueCommentDeletedIssueVariant2State.Closed,
                "open" => WebhookIssueCommentDeletedIssueVariant2State.Open,
                _ => null,
            };
        }
    }
}