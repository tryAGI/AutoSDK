//HintName: G.Models.WebhookSubIssuesSubIssueRemovedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookSubIssuesSubIssueRemovedAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sub_issue_removed")]
        SubIssueRemoved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSubIssuesSubIssueRemovedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSubIssuesSubIssueRemovedAction value)
        {
            return value switch
            {
                WebhookSubIssuesSubIssueRemovedAction.SubIssueRemoved => "sub_issue_removed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSubIssuesSubIssueRemovedAction? ToEnum(string value)
        {
            return value switch
            {
                "sub_issue_removed" => WebhookSubIssuesSubIssueRemovedAction.SubIssueRemoved,
                _ => null,
            };
        }
    }
}