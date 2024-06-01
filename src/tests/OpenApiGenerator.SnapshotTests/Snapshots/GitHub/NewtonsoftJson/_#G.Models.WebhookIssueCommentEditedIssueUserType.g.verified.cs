//HintName: G.Models.WebhookIssueCommentEditedIssueUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentEditedIssueUserType
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
    public static class WebhookIssueCommentEditedIssueUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueUserType value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueUserType.Bot => "Bot",
                WebhookIssueCommentEditedIssueUserType.User => "User",
                WebhookIssueCommentEditedIssueUserType.Organization => "Organization",
                WebhookIssueCommentEditedIssueUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueUserType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentEditedIssueUserType.Bot,
                "User" => WebhookIssueCommentEditedIssueUserType.User,
                "Organization" => WebhookIssueCommentEditedIssueUserType.Organization,
                "Mannequin" => WebhookIssueCommentEditedIssueUserType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}