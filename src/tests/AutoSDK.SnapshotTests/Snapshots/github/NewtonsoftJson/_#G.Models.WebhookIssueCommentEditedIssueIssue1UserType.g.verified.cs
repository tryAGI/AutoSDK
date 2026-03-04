//HintName: G.Models.WebhookIssueCommentEditedIssueIssue1UserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentEditedIssueIssue1UserType
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
    public static class WebhookIssueCommentEditedIssueIssue1UserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueIssue1UserType value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueIssue1UserType.Bot => "Bot",
                WebhookIssueCommentEditedIssueIssue1UserType.User => "User",
                WebhookIssueCommentEditedIssueIssue1UserType.Organization => "Organization",
                WebhookIssueCommentEditedIssueIssue1UserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueIssue1UserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentEditedIssueIssue1UserType.Bot,
                "User" => WebhookIssueCommentEditedIssueIssue1UserType.User,
                "Organization" => WebhookIssueCommentEditedIssueIssue1UserType.Organization,
                "Mannequin" => WebhookIssueCommentEditedIssueIssue1UserType.Mannequin,
                _ => null,
            };
        }
    }
}