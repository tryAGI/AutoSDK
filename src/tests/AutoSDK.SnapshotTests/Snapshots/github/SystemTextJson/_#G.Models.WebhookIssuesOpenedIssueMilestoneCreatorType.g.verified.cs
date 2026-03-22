//HintName: G.Models.WebhookIssuesOpenedIssueMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesOpenedIssueMilestoneCreatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesOpenedIssueMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedIssueMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookIssuesOpenedIssueMilestoneCreatorType.Bot => "Bot",
                WebhookIssuesOpenedIssueMilestoneCreatorType.Mannequin => "Mannequin",
                WebhookIssuesOpenedIssueMilestoneCreatorType.Organization => "Organization",
                WebhookIssuesOpenedIssueMilestoneCreatorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedIssueMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesOpenedIssueMilestoneCreatorType.Bot,
                "Mannequin" => WebhookIssuesOpenedIssueMilestoneCreatorType.Mannequin,
                "Organization" => WebhookIssuesOpenedIssueMilestoneCreatorType.Organization,
                "User" => WebhookIssuesOpenedIssueMilestoneCreatorType.User,
                _ => null,
            };
        }
    }
}