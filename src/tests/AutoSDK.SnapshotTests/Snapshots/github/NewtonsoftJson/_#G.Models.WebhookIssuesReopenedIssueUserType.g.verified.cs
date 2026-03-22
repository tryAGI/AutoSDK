//HintName: G.Models.WebhookIssuesReopenedIssueUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesReopenedIssueUserType
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
    public static class WebhookIssuesReopenedIssueUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesReopenedIssueUserType value)
        {
            return value switch
            {
                WebhookIssuesReopenedIssueUserType.Bot => "Bot",
                WebhookIssuesReopenedIssueUserType.Mannequin => "Mannequin",
                WebhookIssuesReopenedIssueUserType.Organization => "Organization",
                WebhookIssuesReopenedIssueUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesReopenedIssueUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesReopenedIssueUserType.Bot,
                "Mannequin" => WebhookIssuesReopenedIssueUserType.Mannequin,
                "Organization" => WebhookIssuesReopenedIssueUserType.Organization,
                "User" => WebhookIssuesReopenedIssueUserType.User,
                _ => null,
            };
        }
    }
}