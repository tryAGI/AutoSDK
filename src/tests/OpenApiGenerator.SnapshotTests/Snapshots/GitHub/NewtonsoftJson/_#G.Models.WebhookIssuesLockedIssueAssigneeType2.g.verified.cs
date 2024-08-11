//HintName: G.Models.WebhookIssuesLockedIssueAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesLockedIssueAssigneeType2
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesLockedIssueAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLockedIssueAssigneeType2 value)
        {
            return value switch
            {
                WebhookIssuesLockedIssueAssigneeType2.Bot => "Bot",
                WebhookIssuesLockedIssueAssigneeType2.User => "User",
                WebhookIssuesLockedIssueAssigneeType2.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLockedIssueAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesLockedIssueAssigneeType2.Bot,
                "User" => WebhookIssuesLockedIssueAssigneeType2.User,
                "Organization" => WebhookIssuesLockedIssueAssigneeType2.Organization,
                _ => null,
            };
        }
    }
}