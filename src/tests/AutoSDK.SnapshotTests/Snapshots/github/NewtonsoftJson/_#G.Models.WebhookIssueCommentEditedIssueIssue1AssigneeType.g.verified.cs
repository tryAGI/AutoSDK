//HintName: G.Models.WebhookIssueCommentEditedIssueIssue1AssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentEditedIssueIssue1AssigneeType
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
    public static class WebhookIssueCommentEditedIssueIssue1AssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueIssue1AssigneeType value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueIssue1AssigneeType.Bot => "Bot",
                WebhookIssueCommentEditedIssueIssue1AssigneeType.User => "User",
                WebhookIssueCommentEditedIssueIssue1AssigneeType.Organization => "Organization",
                WebhookIssueCommentEditedIssueIssue1AssigneeType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueIssue1AssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentEditedIssueIssue1AssigneeType.Bot,
                "User" => WebhookIssueCommentEditedIssueIssue1AssigneeType.User,
                "Organization" => WebhookIssueCommentEditedIssueIssue1AssigneeType.Organization,
                "Mannequin" => WebhookIssueCommentEditedIssueIssue1AssigneeType.Mannequin,
                _ => null,
            };
        }
    }
}