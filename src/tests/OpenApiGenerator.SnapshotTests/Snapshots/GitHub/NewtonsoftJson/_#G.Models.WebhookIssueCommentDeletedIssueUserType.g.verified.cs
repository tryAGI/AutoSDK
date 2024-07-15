//HintName: G.Models.WebhookIssueCommentDeletedIssueUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentDeletedIssueUserType
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
    public static class WebhookIssueCommentDeletedIssueUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueUserType value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueUserType.Bot => "Bot",
                WebhookIssueCommentDeletedIssueUserType.User => "User",
                WebhookIssueCommentDeletedIssueUserType.Organization => "Organization",
                WebhookIssueCommentDeletedIssueUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentDeletedIssueUserType.Bot,
                "User" => WebhookIssueCommentDeletedIssueUserType.User,
                "Organization" => WebhookIssueCommentDeletedIssueUserType.Organization,
                "Mannequin" => WebhookIssueCommentDeletedIssueUserType.Mannequin,
                _ => null,
            };
        }
    }
}