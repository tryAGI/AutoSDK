//HintName: G.Models.WebhookIssueCommentDeletedIssueVariant1State.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the issue; either 'open' or 'closed'
    /// </summary>
    public enum WebhookIssueCommentDeletedIssueVariant1State
    {
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Closed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueCommentDeletedIssueVariant1StateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueVariant1State value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueVariant1State.Open => "open",
                WebhookIssueCommentDeletedIssueVariant1State.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueVariant1State? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookIssueCommentDeletedIssueVariant1State.Open,
                "closed" => WebhookIssueCommentDeletedIssueVariant1State.Closed,
                _ => null,
            };
        }
    }
}