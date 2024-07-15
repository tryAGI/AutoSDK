//HintName: G.Models.WebhookIssuesEditedIssueUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesEditedIssueUserType
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
    public static class WebhookIssuesEditedIssueUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesEditedIssueUserType value)
        {
            return value switch
            {
                WebhookIssuesEditedIssueUserType.Bot => "Bot",
                WebhookIssuesEditedIssueUserType.User => "User",
                WebhookIssuesEditedIssueUserType.Organization => "Organization",
                WebhookIssuesEditedIssueUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesEditedIssueUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesEditedIssueUserType.Bot,
                "User" => WebhookIssuesEditedIssueUserType.User,
                "Organization" => WebhookIssuesEditedIssueUserType.Organization,
                "Mannequin" => WebhookIssuesEditedIssueUserType.Mannequin,
                _ => null,
            };
        }
    }
}