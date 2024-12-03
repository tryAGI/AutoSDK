//HintName: G.Models.WebhookIssueCommentDeletedIssueVariant1AssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentDeletedIssueVariant1AssigneeType2
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
    public static class WebhookIssueCommentDeletedIssueVariant1AssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueVariant1AssigneeType2 value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueVariant1AssigneeType2.Bot => "Bot",
                WebhookIssueCommentDeletedIssueVariant1AssigneeType2.User => "User",
                WebhookIssueCommentDeletedIssueVariant1AssigneeType2.Organization => "Organization",
                WebhookIssueCommentDeletedIssueVariant1AssigneeType2.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueVariant1AssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentDeletedIssueVariant1AssigneeType2.Bot,
                "User" => WebhookIssueCommentDeletedIssueVariant1AssigneeType2.User,
                "Organization" => WebhookIssueCommentDeletedIssueVariant1AssigneeType2.Organization,
                "Mannequin" => WebhookIssueCommentDeletedIssueVariant1AssigneeType2.Mannequin,
                _ => null,
            };
        }
    }
}