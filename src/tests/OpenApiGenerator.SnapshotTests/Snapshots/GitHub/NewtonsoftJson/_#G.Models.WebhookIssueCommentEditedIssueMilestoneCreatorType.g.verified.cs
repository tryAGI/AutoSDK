//HintName: G.Models.WebhookIssueCommentEditedIssueMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentEditedIssueMilestoneCreatorType
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
    public static class WebhookIssueCommentEditedIssueMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueMilestoneCreatorType.Bot => "Bot",
                WebhookIssueCommentEditedIssueMilestoneCreatorType.User => "User",
                WebhookIssueCommentEditedIssueMilestoneCreatorType.Organization => "Organization",
                WebhookIssueCommentEditedIssueMilestoneCreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentEditedIssueMilestoneCreatorType.Bot,
                "User" => WebhookIssueCommentEditedIssueMilestoneCreatorType.User,
                "Organization" => WebhookIssueCommentEditedIssueMilestoneCreatorType.Organization,
                "Mannequin" => WebhookIssueCommentEditedIssueMilestoneCreatorType.Mannequin,
                _ => null,
            };
        }
    }
}