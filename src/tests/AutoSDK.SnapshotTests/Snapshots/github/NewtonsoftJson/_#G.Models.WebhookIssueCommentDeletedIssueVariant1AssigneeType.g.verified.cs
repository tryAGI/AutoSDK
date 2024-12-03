//HintName: G.Models.WebhookIssueCommentDeletedIssueVariant1AssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentDeletedIssueVariant1AssigneeType
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
    public static class WebhookIssueCommentDeletedIssueVariant1AssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueVariant1AssigneeType value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueVariant1AssigneeType.Bot => "Bot",
                WebhookIssueCommentDeletedIssueVariant1AssigneeType.User => "User",
                WebhookIssueCommentDeletedIssueVariant1AssigneeType.Organization => "Organization",
                WebhookIssueCommentDeletedIssueVariant1AssigneeType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueVariant1AssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentDeletedIssueVariant1AssigneeType.Bot,
                "User" => WebhookIssueCommentDeletedIssueVariant1AssigneeType.User,
                "Organization" => WebhookIssueCommentDeletedIssueVariant1AssigneeType.Organization,
                "Mannequin" => WebhookIssueCommentDeletedIssueVariant1AssigneeType.Mannequin,
                _ => null,
            };
        }
    }
}