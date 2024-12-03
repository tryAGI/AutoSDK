//HintName: G.Models.WebhookIssuesLockedIssueMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesLockedIssueMilestoneCreatorType
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
    public static class WebhookIssuesLockedIssueMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLockedIssueMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookIssuesLockedIssueMilestoneCreatorType.Bot => "Bot",
                WebhookIssuesLockedIssueMilestoneCreatorType.User => "User",
                WebhookIssuesLockedIssueMilestoneCreatorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLockedIssueMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesLockedIssueMilestoneCreatorType.Bot,
                "User" => WebhookIssuesLockedIssueMilestoneCreatorType.User,
                "Organization" => WebhookIssuesLockedIssueMilestoneCreatorType.Organization,
                _ => null,
            };
        }
    }
}