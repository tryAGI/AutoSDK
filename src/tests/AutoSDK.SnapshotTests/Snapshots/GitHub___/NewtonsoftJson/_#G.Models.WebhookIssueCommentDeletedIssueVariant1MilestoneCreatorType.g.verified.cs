//HintName: G.Models.WebhookIssueCommentDeletedIssueVariant1MilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentDeletedIssueVariant1MilestoneCreatorType
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
    public static class WebhookIssueCommentDeletedIssueVariant1MilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueVariant1MilestoneCreatorType value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueVariant1MilestoneCreatorType.Bot => "Bot",
                WebhookIssueCommentDeletedIssueVariant1MilestoneCreatorType.User => "User",
                WebhookIssueCommentDeletedIssueVariant1MilestoneCreatorType.Organization => "Organization",
                WebhookIssueCommentDeletedIssueVariant1MilestoneCreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueVariant1MilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentDeletedIssueVariant1MilestoneCreatorType.Bot,
                "User" => WebhookIssueCommentDeletedIssueVariant1MilestoneCreatorType.User,
                "Organization" => WebhookIssueCommentDeletedIssueVariant1MilestoneCreatorType.Organization,
                "Mannequin" => WebhookIssueCommentDeletedIssueVariant1MilestoneCreatorType.Mannequin,
                _ => null,
            };
        }
    }
}