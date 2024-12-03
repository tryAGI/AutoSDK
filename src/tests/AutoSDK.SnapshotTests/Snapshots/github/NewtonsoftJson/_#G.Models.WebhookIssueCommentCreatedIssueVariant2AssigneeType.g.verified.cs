//HintName: G.Models.WebhookIssueCommentCreatedIssueVariant2AssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentCreatedIssueVariant2AssigneeType
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
    public static class WebhookIssueCommentCreatedIssueVariant2AssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueVariant2AssigneeType value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueVariant2AssigneeType.Bot => "Bot",
                WebhookIssueCommentCreatedIssueVariant2AssigneeType.User => "User",
                WebhookIssueCommentCreatedIssueVariant2AssigneeType.Organization => "Organization",
                WebhookIssueCommentCreatedIssueVariant2AssigneeType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueVariant2AssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentCreatedIssueVariant2AssigneeType.Bot,
                "User" => WebhookIssueCommentCreatedIssueVariant2AssigneeType.User,
                "Organization" => WebhookIssueCommentCreatedIssueVariant2AssigneeType.Organization,
                "Mannequin" => WebhookIssueCommentCreatedIssueVariant2AssigneeType.Mannequin,
                _ => null,
            };
        }
    }
}