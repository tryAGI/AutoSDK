//HintName: G.Models.WebhookIssueCommentCreatedIssueMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentCreatedIssueMilestoneCreatorType
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
    public static class WebhookIssueCommentCreatedIssueMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueMilestoneCreatorType.Bot => "Bot",
                WebhookIssueCommentCreatedIssueMilestoneCreatorType.User => "User",
                WebhookIssueCommentCreatedIssueMilestoneCreatorType.Organization => "Organization",
                WebhookIssueCommentCreatedIssueMilestoneCreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentCreatedIssueMilestoneCreatorType.Bot,
                "User" => WebhookIssueCommentCreatedIssueMilestoneCreatorType.User,
                "Organization" => WebhookIssueCommentCreatedIssueMilestoneCreatorType.Organization,
                "Mannequin" => WebhookIssueCommentCreatedIssueMilestoneCreatorType.Mannequin,
                _ => null,
            };
        }
    }
}