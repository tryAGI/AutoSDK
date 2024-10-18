//HintName: G.Models.WebhookSubIssuesSubIssueAddedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookSubIssuesSubIssueAddedAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sub_issue_added")]
        SubIssueAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSubIssuesSubIssueAddedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSubIssuesSubIssueAddedAction value)
        {
            return value switch
            {
                WebhookSubIssuesSubIssueAddedAction.SubIssueAdded => "sub_issue_added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSubIssuesSubIssueAddedAction? ToEnum(string value)
        {
            return value switch
            {
                "sub_issue_added" => WebhookSubIssuesSubIssueAddedAction.SubIssueAdded,
                _ => null,
            };
        }
    }
}