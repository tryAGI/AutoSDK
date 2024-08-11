//HintName: G.Models.WebhookIssueCommentCreatedIssueVariant1MilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentCreatedIssueVariant1MilestoneCreatorType
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
    public static class WebhookIssueCommentCreatedIssueVariant1MilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueVariant1MilestoneCreatorType value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueVariant1MilestoneCreatorType.Bot => "Bot",
                WebhookIssueCommentCreatedIssueVariant1MilestoneCreatorType.User => "User",
                WebhookIssueCommentCreatedIssueVariant1MilestoneCreatorType.Organization => "Organization",
                WebhookIssueCommentCreatedIssueVariant1MilestoneCreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueVariant1MilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentCreatedIssueVariant1MilestoneCreatorType.Bot,
                "User" => WebhookIssueCommentCreatedIssueVariant1MilestoneCreatorType.User,
                "Organization" => WebhookIssueCommentCreatedIssueVariant1MilestoneCreatorType.Organization,
                "Mannequin" => WebhookIssueCommentCreatedIssueVariant1MilestoneCreatorType.Mannequin,
                _ => null,
            };
        }
    }
}