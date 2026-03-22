//HintName: G.Models.WebhookIssuesLabeledIssueAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesLabeledIssueAssigneeType
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
    public static class WebhookIssuesLabeledIssueAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLabeledIssueAssigneeType value)
        {
            return value switch
            {
                WebhookIssuesLabeledIssueAssigneeType.Bot => "Bot",
                WebhookIssuesLabeledIssueAssigneeType.Mannequin => "Mannequin",
                WebhookIssuesLabeledIssueAssigneeType.Organization => "Organization",
                WebhookIssuesLabeledIssueAssigneeType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLabeledIssueAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesLabeledIssueAssigneeType.Bot,
                "Mannequin" => WebhookIssuesLabeledIssueAssigneeType.Mannequin,
                "Organization" => WebhookIssuesLabeledIssueAssigneeType.Organization,
                "User" => WebhookIssuesLabeledIssueAssigneeType.User,
                _ => null,
            };
        }
    }
}