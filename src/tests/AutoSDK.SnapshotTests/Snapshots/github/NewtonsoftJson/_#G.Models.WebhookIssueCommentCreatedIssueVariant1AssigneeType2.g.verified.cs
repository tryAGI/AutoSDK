//HintName: G.Models.WebhookIssueCommentCreatedIssueVariant1AssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentCreatedIssueVariant1AssigneeType2
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
    public static class WebhookIssueCommentCreatedIssueVariant1AssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueVariant1AssigneeType2 value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueVariant1AssigneeType2.Bot => "Bot",
                WebhookIssueCommentCreatedIssueVariant1AssigneeType2.User => "User",
                WebhookIssueCommentCreatedIssueVariant1AssigneeType2.Organization => "Organization",
                WebhookIssueCommentCreatedIssueVariant1AssigneeType2.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueVariant1AssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentCreatedIssueVariant1AssigneeType2.Bot,
                "User" => WebhookIssueCommentCreatedIssueVariant1AssigneeType2.User,
                "Organization" => WebhookIssueCommentCreatedIssueVariant1AssigneeType2.Organization,
                "Mannequin" => WebhookIssueCommentCreatedIssueVariant1AssigneeType2.Mannequin,
                _ => null,
            };
        }
    }
}