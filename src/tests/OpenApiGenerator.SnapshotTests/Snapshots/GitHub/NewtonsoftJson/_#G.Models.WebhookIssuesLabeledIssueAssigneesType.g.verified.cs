//HintName: G.Models.WebhookIssuesLabeledIssueAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesLabeledIssueAssigneesType
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
    public static class WebhookIssuesLabeledIssueAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLabeledIssueAssigneesType value)
        {
            return value switch
            {
                WebhookIssuesLabeledIssueAssigneesType.Bot => "Bot",
                WebhookIssuesLabeledIssueAssigneesType.User => "User",
                WebhookIssuesLabeledIssueAssigneesType.Organization => "Organization",
                WebhookIssuesLabeledIssueAssigneesType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLabeledIssueAssigneesType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesLabeledIssueAssigneesType.Bot,
                "User" => WebhookIssuesLabeledIssueAssigneesType.User,
                "Organization" => WebhookIssuesLabeledIssueAssigneesType.Organization,
                "Mannequin" => WebhookIssuesLabeledIssueAssigneesType.Mannequin,
                _ => null,
            };
        }
    }
}