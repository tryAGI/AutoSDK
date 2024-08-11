//HintName: G.Models.WebhookIssuesClosedIssueVariant1AssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesClosedIssueVariant1AssigneeType2
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
    public static class WebhookIssuesClosedIssueVariant1AssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueVariant1AssigneeType2 value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueVariant1AssigneeType2.Bot => "Bot",
                WebhookIssuesClosedIssueVariant1AssigneeType2.User => "User",
                WebhookIssuesClosedIssueVariant1AssigneeType2.Organization => "Organization",
                WebhookIssuesClosedIssueVariant1AssigneeType2.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueVariant1AssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesClosedIssueVariant1AssigneeType2.Bot,
                "User" => WebhookIssuesClosedIssueVariant1AssigneeType2.User,
                "Organization" => WebhookIssuesClosedIssueVariant1AssigneeType2.Organization,
                "Mannequin" => WebhookIssuesClosedIssueVariant1AssigneeType2.Mannequin,
                _ => null,
            };
        }
    }
}