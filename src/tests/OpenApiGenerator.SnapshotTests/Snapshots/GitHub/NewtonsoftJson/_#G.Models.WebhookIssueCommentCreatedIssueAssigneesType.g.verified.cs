//HintName: G.Models.WebhookIssueCommentCreatedIssueAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentCreatedIssueAssigneesType
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
    public static class WebhookIssueCommentCreatedIssueAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueAssigneesType value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueAssigneesType.Bot => "Bot",
                WebhookIssueCommentCreatedIssueAssigneesType.User => "User",
                WebhookIssueCommentCreatedIssueAssigneesType.Organization => "Organization",
                WebhookIssueCommentCreatedIssueAssigneesType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueAssigneesType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentCreatedIssueAssigneesType.Bot,
                "User" => WebhookIssueCommentCreatedIssueAssigneesType.User,
                "Organization" => WebhookIssueCommentCreatedIssueAssigneesType.Organization,
                "Mannequin" => WebhookIssueCommentCreatedIssueAssigneesType.Mannequin,
                _ => null,
            };
        }
    }
}