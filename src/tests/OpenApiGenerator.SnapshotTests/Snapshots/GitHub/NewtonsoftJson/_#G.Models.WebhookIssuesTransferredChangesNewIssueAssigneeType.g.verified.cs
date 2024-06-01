//HintName: G.Models.WebhookIssuesTransferredChangesNewIssueAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesTransferredChangesNewIssueAssigneeType
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
    public static class WebhookIssuesTransferredChangesNewIssueAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesTransferredChangesNewIssueAssigneeType value)
        {
            return value switch
            {
                WebhookIssuesTransferredChangesNewIssueAssigneeType.Bot => "Bot",
                WebhookIssuesTransferredChangesNewIssueAssigneeType.User => "User",
                WebhookIssuesTransferredChangesNewIssueAssigneeType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesTransferredChangesNewIssueAssigneeType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesTransferredChangesNewIssueAssigneeType.Bot,
                "User" => WebhookIssuesTransferredChangesNewIssueAssigneeType.User,
                "Organization" => WebhookIssuesTransferredChangesNewIssueAssigneeType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}