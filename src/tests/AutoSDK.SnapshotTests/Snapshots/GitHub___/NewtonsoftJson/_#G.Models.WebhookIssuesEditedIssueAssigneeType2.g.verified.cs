//HintName: G.Models.WebhookIssuesEditedIssueAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesEditedIssueAssigneeType2
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
    public static class WebhookIssuesEditedIssueAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesEditedIssueAssigneeType2 value)
        {
            return value switch
            {
                WebhookIssuesEditedIssueAssigneeType2.Bot => "Bot",
                WebhookIssuesEditedIssueAssigneeType2.User => "User",
                WebhookIssuesEditedIssueAssigneeType2.Organization => "Organization",
                WebhookIssuesEditedIssueAssigneeType2.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesEditedIssueAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesEditedIssueAssigneeType2.Bot,
                "User" => WebhookIssuesEditedIssueAssigneeType2.User,
                "Organization" => WebhookIssuesEditedIssueAssigneeType2.Organization,
                "Mannequin" => WebhookIssuesEditedIssueAssigneeType2.Mannequin,
                _ => null,
            };
        }
    }
}