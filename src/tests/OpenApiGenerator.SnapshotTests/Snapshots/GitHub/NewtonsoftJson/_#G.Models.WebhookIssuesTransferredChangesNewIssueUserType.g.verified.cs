//HintName: G.Models.WebhookIssuesTransferredChangesNewIssueUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesTransferredChangesNewIssueUserType
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
    public static class WebhookIssuesTransferredChangesNewIssueUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesTransferredChangesNewIssueUserType value)
        {
            return value switch
            {
                WebhookIssuesTransferredChangesNewIssueUserType.Bot => "Bot",
                WebhookIssuesTransferredChangesNewIssueUserType.User => "User",
                WebhookIssuesTransferredChangesNewIssueUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesTransferredChangesNewIssueUserType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesTransferredChangesNewIssueUserType.Bot,
                "User" => WebhookIssuesTransferredChangesNewIssueUserType.User,
                "Organization" => WebhookIssuesTransferredChangesNewIssueUserType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}