//HintName: G.Models.WebhookSubIssuesParentIssueRemovedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookSubIssuesParentIssueRemovedAction
    {
        /// <summary>
        /// 
        /// </summary>
        ParentIssueRemoved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSubIssuesParentIssueRemovedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSubIssuesParentIssueRemovedAction value)
        {
            return value switch
            {
                WebhookSubIssuesParentIssueRemovedAction.ParentIssueRemoved => "parent_issue_removed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSubIssuesParentIssueRemovedAction? ToEnum(string value)
        {
            return value switch
            {
                "parent_issue_removed" => WebhookSubIssuesParentIssueRemovedAction.ParentIssueRemoved,
                _ => null,
            };
        }
    }
}