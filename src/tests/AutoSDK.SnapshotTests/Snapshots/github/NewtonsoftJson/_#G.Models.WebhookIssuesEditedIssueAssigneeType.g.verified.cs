//HintName: G.Models.WebhookIssuesEditedIssueAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesEditedIssueAssigneeType
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
    public static class WebhookIssuesEditedIssueAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesEditedIssueAssigneeType value)
        {
            return value switch
            {
                WebhookIssuesEditedIssueAssigneeType.Bot => "Bot",
                WebhookIssuesEditedIssueAssigneeType.Mannequin => "Mannequin",
                WebhookIssuesEditedIssueAssigneeType.Organization => "Organization",
                WebhookIssuesEditedIssueAssigneeType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesEditedIssueAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesEditedIssueAssigneeType.Bot,
                "Mannequin" => WebhookIssuesEditedIssueAssigneeType.Mannequin,
                "Organization" => WebhookIssuesEditedIssueAssigneeType.Organization,
                "User" => WebhookIssuesEditedIssueAssigneeType.User,
                _ => null,
            };
        }
    }
}