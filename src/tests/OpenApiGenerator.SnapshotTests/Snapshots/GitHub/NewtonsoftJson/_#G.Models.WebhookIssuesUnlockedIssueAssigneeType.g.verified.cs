//HintName: G.Models.WebhookIssuesUnlockedIssueAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesUnlockedIssueAssigneeType
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
    public static class WebhookIssuesUnlockedIssueAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesUnlockedIssueAssigneeType value)
        {
            return value switch
            {
                WebhookIssuesUnlockedIssueAssigneeType.Bot => "Bot",
                WebhookIssuesUnlockedIssueAssigneeType.User => "User",
                WebhookIssuesUnlockedIssueAssigneeType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesUnlockedIssueAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesUnlockedIssueAssigneeType.Bot,
                "User" => WebhookIssuesUnlockedIssueAssigneeType.User,
                "Organization" => WebhookIssuesUnlockedIssueAssigneeType.Organization,
                _ => null,
            };
        }
    }
}