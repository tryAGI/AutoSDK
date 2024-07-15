//HintName: G.Models.WebhookIssuesTransferredChangesNewIssueMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesTransferredChangesNewIssueMilestoneCreatorType
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
    public static class WebhookIssuesTransferredChangesNewIssueMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesTransferredChangesNewIssueMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookIssuesTransferredChangesNewIssueMilestoneCreatorType.Bot => "Bot",
                WebhookIssuesTransferredChangesNewIssueMilestoneCreatorType.User => "User",
                WebhookIssuesTransferredChangesNewIssueMilestoneCreatorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesTransferredChangesNewIssueMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesTransferredChangesNewIssueMilestoneCreatorType.Bot,
                "User" => WebhookIssuesTransferredChangesNewIssueMilestoneCreatorType.User,
                "Organization" => WebhookIssuesTransferredChangesNewIssueMilestoneCreatorType.Organization,
                _ => null,
            };
        }
    }
}