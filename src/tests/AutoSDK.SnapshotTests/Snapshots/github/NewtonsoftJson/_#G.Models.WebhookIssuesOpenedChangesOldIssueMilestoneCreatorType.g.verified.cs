//HintName: G.Models.WebhookIssuesOpenedChangesOldIssueMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesOpenedChangesOldIssueMilestoneCreatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
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
    public static class WebhookIssuesOpenedChangesOldIssueMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedChangesOldIssueMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookIssuesOpenedChangesOldIssueMilestoneCreatorType.Bot => "Bot",
                WebhookIssuesOpenedChangesOldIssueMilestoneCreatorType.Organization => "Organization",
                WebhookIssuesOpenedChangesOldIssueMilestoneCreatorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedChangesOldIssueMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesOpenedChangesOldIssueMilestoneCreatorType.Bot,
                "Organization" => WebhookIssuesOpenedChangesOldIssueMilestoneCreatorType.Organization,
                "User" => WebhookIssuesOpenedChangesOldIssueMilestoneCreatorType.User,
                _ => null,
            };
        }
    }
}