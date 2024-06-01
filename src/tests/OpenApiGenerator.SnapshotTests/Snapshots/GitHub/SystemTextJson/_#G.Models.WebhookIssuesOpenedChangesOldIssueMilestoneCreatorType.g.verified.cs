//HintName: G.Models.WebhookIssuesOpenedChangesOldIssueMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesOpenedChangesOldIssueMilestoneCreatorType
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
                WebhookIssuesOpenedChangesOldIssueMilestoneCreatorType.User => "User",
                WebhookIssuesOpenedChangesOldIssueMilestoneCreatorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedChangesOldIssueMilestoneCreatorType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesOpenedChangesOldIssueMilestoneCreatorType.Bot,
                "User" => WebhookIssuesOpenedChangesOldIssueMilestoneCreatorType.User,
                "Organization" => WebhookIssuesOpenedChangesOldIssueMilestoneCreatorType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}