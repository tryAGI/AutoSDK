//HintName: G.Models.WebhookIssueCommentCreatedIssueVariant1UserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentCreatedIssueVariant1UserType
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
    public static class WebhookIssueCommentCreatedIssueVariant1UserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueVariant1UserType value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueVariant1UserType.Bot => "Bot",
                WebhookIssueCommentCreatedIssueVariant1UserType.User => "User",
                WebhookIssueCommentCreatedIssueVariant1UserType.Organization => "Organization",
                WebhookIssueCommentCreatedIssueVariant1UserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueVariant1UserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentCreatedIssueVariant1UserType.Bot,
                "User" => WebhookIssueCommentCreatedIssueVariant1UserType.User,
                "Organization" => WebhookIssueCommentCreatedIssueVariant1UserType.Organization,
                "Mannequin" => WebhookIssueCommentCreatedIssueVariant1UserType.Mannequin,
                _ => null,
            };
        }
    }
}