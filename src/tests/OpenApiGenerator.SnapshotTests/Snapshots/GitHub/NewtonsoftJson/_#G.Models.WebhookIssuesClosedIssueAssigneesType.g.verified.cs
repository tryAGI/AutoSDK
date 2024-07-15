//HintName: G.Models.WebhookIssuesClosedIssueAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesClosedIssueAssigneesType
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
    public static class WebhookIssuesClosedIssueAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueAssigneesType value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueAssigneesType.Bot => "Bot",
                WebhookIssuesClosedIssueAssigneesType.User => "User",
                WebhookIssuesClosedIssueAssigneesType.Organization => "Organization",
                WebhookIssuesClosedIssueAssigneesType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueAssigneesType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesClosedIssueAssigneesType.Bot,
                "User" => WebhookIssuesClosedIssueAssigneesType.User,
                "Organization" => WebhookIssuesClosedIssueAssigneesType.Organization,
                "Mannequin" => WebhookIssuesClosedIssueAssigneesType.Mannequin,
                _ => null,
            };
        }
    }
}