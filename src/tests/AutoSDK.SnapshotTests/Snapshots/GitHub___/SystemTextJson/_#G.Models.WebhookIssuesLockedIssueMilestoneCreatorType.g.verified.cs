//HintName: G.Models.WebhookIssuesLockedIssueMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesLockedIssueMilestoneCreatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
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