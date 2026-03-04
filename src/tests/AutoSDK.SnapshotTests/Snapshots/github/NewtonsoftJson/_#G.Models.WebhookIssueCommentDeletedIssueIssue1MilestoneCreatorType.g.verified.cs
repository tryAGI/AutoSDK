//HintName: G.Models.WebhookIssueCommentDeletedIssueIssue1MilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentDeletedIssueIssue1MilestoneCreatorType
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
    public static class WebhookIssueCommentDeletedIssueIssue1MilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueIssue1MilestoneCreatorType value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueIssue1MilestoneCreatorType.Bot => "Bot",
                WebhookIssueCommentDeletedIssueIssue1MilestoneCreatorType.User => "User",
                WebhookIssueCommentDeletedIssueIssue1MilestoneCreatorType.Organization => "Organization",
                WebhookIssueCommentDeletedIssueIssue1MilestoneCreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueIssue1MilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentDeletedIssueIssue1MilestoneCreatorType.Bot,
                "User" => WebhookIssueCommentDeletedIssueIssue1MilestoneCreatorType.User,
                "Organization" => WebhookIssueCommentDeletedIssueIssue1MilestoneCreatorType.Organization,
                "Mannequin" => WebhookIssueCommentDeletedIssueIssue1MilestoneCreatorType.Mannequin,
                _ => null,
            };
        }
    }
}