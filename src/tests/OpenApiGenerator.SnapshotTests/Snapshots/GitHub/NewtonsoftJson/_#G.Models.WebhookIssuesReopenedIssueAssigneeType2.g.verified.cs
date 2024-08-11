//HintName: G.Models.WebhookIssuesReopenedIssueAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesReopenedIssueAssigneeType2
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
    public static class WebhookIssuesReopenedIssueAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesReopenedIssueAssigneeType2 value)
        {
            return value switch
            {
                WebhookIssuesReopenedIssueAssigneeType2.Bot => "Bot",
                WebhookIssuesReopenedIssueAssigneeType2.User => "User",
                WebhookIssuesReopenedIssueAssigneeType2.Organization => "Organization",
                WebhookIssuesReopenedIssueAssigneeType2.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesReopenedIssueAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesReopenedIssueAssigneeType2.Bot,
                "User" => WebhookIssuesReopenedIssueAssigneeType2.User,
                "Organization" => WebhookIssuesReopenedIssueAssigneeType2.Organization,
                "Mannequin" => WebhookIssuesReopenedIssueAssigneeType2.Mannequin,
                _ => null,
            };
        }
    }
}