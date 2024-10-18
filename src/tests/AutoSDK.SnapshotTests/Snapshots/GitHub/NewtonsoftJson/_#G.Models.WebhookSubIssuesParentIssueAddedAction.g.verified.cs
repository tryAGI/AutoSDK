//HintName: G.Models.WebhookSubIssuesParentIssueAddedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookSubIssuesParentIssueAddedAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parent_issue_added")]
        ParentIssueAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSubIssuesParentIssueAddedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSubIssuesParentIssueAddedAction value)
        {
            return value switch
            {
                WebhookSubIssuesParentIssueAddedAction.ParentIssueAdded => "parent_issue_added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSubIssuesParentIssueAddedAction? ToEnum(string value)
        {
            return value switch
            {
                "parent_issue_added" => WebhookSubIssuesParentIssueAddedAction.ParentIssueAdded,
                _ => null,
            };
        }
    }
}