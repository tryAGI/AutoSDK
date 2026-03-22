//HintName: G.Models.WebhookIssueCommentDeletedIssueIssue1UserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentDeletedIssueIssue1UserType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Mannequin")]
        Mannequin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueCommentDeletedIssueIssue1UserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueIssue1UserType value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueIssue1UserType.Bot => "Bot",
                WebhookIssueCommentDeletedIssueIssue1UserType.Mannequin => "Mannequin",
                WebhookIssueCommentDeletedIssueIssue1UserType.Organization => "Organization",
                WebhookIssueCommentDeletedIssueIssue1UserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueIssue1UserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentDeletedIssueIssue1UserType.Bot,
                "Mannequin" => WebhookIssueCommentDeletedIssueIssue1UserType.Mannequin,
                "Organization" => WebhookIssueCommentDeletedIssueIssue1UserType.Organization,
                "User" => WebhookIssueCommentDeletedIssueIssue1UserType.User,
                _ => null,
            };
        }
    }
}