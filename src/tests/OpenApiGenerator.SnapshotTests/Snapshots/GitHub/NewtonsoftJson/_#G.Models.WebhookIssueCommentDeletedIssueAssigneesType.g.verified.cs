//HintName: G.Models.WebhookIssueCommentDeletedIssueAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentDeletedIssueAssigneesType
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
    public static class WebhookIssueCommentDeletedIssueAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueAssigneesType value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueAssigneesType.Bot => "Bot",
                WebhookIssueCommentDeletedIssueAssigneesType.User => "User",
                WebhookIssueCommentDeletedIssueAssigneesType.Organization => "Organization",
                WebhookIssueCommentDeletedIssueAssigneesType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueAssigneesType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentDeletedIssueAssigneesType.Bot,
                "User" => WebhookIssueCommentDeletedIssueAssigneesType.User,
                "Organization" => WebhookIssueCommentDeletedIssueAssigneesType.Organization,
                "Mannequin" => WebhookIssueCommentDeletedIssueAssigneesType.Mannequin,
                _ => null,
            };
        }
    }
}