//HintName: G.Models.WebhookIssueCommentCreatedIssueIssue1AssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentCreatedIssueIssue1AssigneeType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Mannequin")]
        Mannequin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueCommentCreatedIssueIssue1AssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueIssue1AssigneeType value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueIssue1AssigneeType.Bot => "Bot",
                WebhookIssueCommentCreatedIssueIssue1AssigneeType.Mannequin => "Mannequin",
                WebhookIssueCommentCreatedIssueIssue1AssigneeType.Organization => "Organization",
                WebhookIssueCommentCreatedIssueIssue1AssigneeType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueIssue1AssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentCreatedIssueIssue1AssigneeType.Bot,
                "Mannequin" => WebhookIssueCommentCreatedIssueIssue1AssigneeType.Mannequin,
                "Organization" => WebhookIssueCommentCreatedIssueIssue1AssigneeType.Organization,
                "User" => WebhookIssueCommentCreatedIssueIssue1AssigneeType.User,
                _ => null,
            };
        }
    }
}