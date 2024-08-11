//HintName: G.Models.WebhookIssuesTransferredChangesNewIssueAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesTransferredChangesNewIssueAssigneeType2
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
    public static class WebhookIssuesTransferredChangesNewIssueAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesTransferredChangesNewIssueAssigneeType2 value)
        {
            return value switch
            {
                WebhookIssuesTransferredChangesNewIssueAssigneeType2.Bot => "Bot",
                WebhookIssuesTransferredChangesNewIssueAssigneeType2.User => "User",
                WebhookIssuesTransferredChangesNewIssueAssigneeType2.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesTransferredChangesNewIssueAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesTransferredChangesNewIssueAssigneeType2.Bot,
                "User" => WebhookIssuesTransferredChangesNewIssueAssigneeType2.User,
                "Organization" => WebhookIssuesTransferredChangesNewIssueAssigneeType2.Organization,
                _ => null,
            };
        }
    }
}