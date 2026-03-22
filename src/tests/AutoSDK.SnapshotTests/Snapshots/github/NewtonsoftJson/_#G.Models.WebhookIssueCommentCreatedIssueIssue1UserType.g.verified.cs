//HintName: G.Models.WebhookIssueCommentCreatedIssueIssue1UserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentCreatedIssueIssue1UserType
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
    public static class WebhookIssueCommentCreatedIssueIssue1UserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueIssue1UserType value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueIssue1UserType.Bot => "Bot",
                WebhookIssueCommentCreatedIssueIssue1UserType.Mannequin => "Mannequin",
                WebhookIssueCommentCreatedIssueIssue1UserType.Organization => "Organization",
                WebhookIssueCommentCreatedIssueIssue1UserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueIssue1UserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentCreatedIssueIssue1UserType.Bot,
                "Mannequin" => WebhookIssueCommentCreatedIssueIssue1UserType.Mannequin,
                "Organization" => WebhookIssueCommentCreatedIssueIssue1UserType.Organization,
                "User" => WebhookIssueCommentCreatedIssueIssue1UserType.User,
                _ => null,
            };
        }
    }
}