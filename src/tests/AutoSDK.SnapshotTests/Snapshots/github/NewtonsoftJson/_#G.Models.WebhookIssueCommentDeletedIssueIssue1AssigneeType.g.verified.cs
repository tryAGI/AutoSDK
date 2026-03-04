//HintName: G.Models.WebhookIssueCommentDeletedIssueIssue1AssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentDeletedIssueIssue1AssigneeType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Mannequin")]
        Mannequin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueCommentDeletedIssueIssue1AssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueIssue1AssigneeType value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueIssue1AssigneeType.Bot => "Bot",
                WebhookIssueCommentDeletedIssueIssue1AssigneeType.User => "User",
                WebhookIssueCommentDeletedIssueIssue1AssigneeType.Organization => "Organization",
                WebhookIssueCommentDeletedIssueIssue1AssigneeType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueIssue1AssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentDeletedIssueIssue1AssigneeType.Bot,
                "User" => WebhookIssueCommentDeletedIssueIssue1AssigneeType.User,
                "Organization" => WebhookIssueCommentDeletedIssueIssue1AssigneeType.Organization,
                "Mannequin" => WebhookIssueCommentDeletedIssueIssue1AssigneeType.Mannequin,
                _ => null,
            };
        }
    }
}