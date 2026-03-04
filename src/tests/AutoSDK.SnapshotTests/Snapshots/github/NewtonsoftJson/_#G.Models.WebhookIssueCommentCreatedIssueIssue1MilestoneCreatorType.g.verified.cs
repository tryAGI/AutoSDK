//HintName: G.Models.WebhookIssueCommentCreatedIssueIssue1MilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentCreatedIssueIssue1MilestoneCreatorType
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
    public static class WebhookIssueCommentCreatedIssueIssue1MilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueIssue1MilestoneCreatorType value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueIssue1MilestoneCreatorType.Bot => "Bot",
                WebhookIssueCommentCreatedIssueIssue1MilestoneCreatorType.User => "User",
                WebhookIssueCommentCreatedIssueIssue1MilestoneCreatorType.Organization => "Organization",
                WebhookIssueCommentCreatedIssueIssue1MilestoneCreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueIssue1MilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentCreatedIssueIssue1MilestoneCreatorType.Bot,
                "User" => WebhookIssueCommentCreatedIssueIssue1MilestoneCreatorType.User,
                "Organization" => WebhookIssueCommentCreatedIssueIssue1MilestoneCreatorType.Organization,
                "Mannequin" => WebhookIssueCommentCreatedIssueIssue1MilestoneCreatorType.Mannequin,
                _ => null,
            };
        }
    }
}