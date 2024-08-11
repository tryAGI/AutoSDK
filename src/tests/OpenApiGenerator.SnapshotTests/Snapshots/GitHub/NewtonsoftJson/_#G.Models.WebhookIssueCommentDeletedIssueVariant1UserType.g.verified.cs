//HintName: G.Models.WebhookIssueCommentDeletedIssueVariant1UserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentDeletedIssueVariant1UserType
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
    public static class WebhookIssueCommentDeletedIssueVariant1UserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueVariant1UserType value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueVariant1UserType.Bot => "Bot",
                WebhookIssueCommentDeletedIssueVariant1UserType.User => "User",
                WebhookIssueCommentDeletedIssueVariant1UserType.Organization => "Organization",
                WebhookIssueCommentDeletedIssueVariant1UserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueVariant1UserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentDeletedIssueVariant1UserType.Bot,
                "User" => WebhookIssueCommentDeletedIssueVariant1UserType.User,
                "Organization" => WebhookIssueCommentDeletedIssueVariant1UserType.Organization,
                "Mannequin" => WebhookIssueCommentDeletedIssueVariant1UserType.Mannequin,
                _ => null,
            };
        }
    }
}