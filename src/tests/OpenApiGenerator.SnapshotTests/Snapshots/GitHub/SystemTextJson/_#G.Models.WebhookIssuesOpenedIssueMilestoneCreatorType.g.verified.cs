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
        User,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
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
                WebhookIssuesOpenedIssueMilestoneCreatorType.User => "User",
                WebhookIssuesOpenedIssueMilestoneCreatorType.Organization => "Organization",
                WebhookIssuesOpenedIssueMilestoneCreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedIssueMilestoneCreatorType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesOpenedIssueMilestoneCreatorType.Bot,
                "User" => WebhookIssuesOpenedIssueMilestoneCreatorType.User,
                "Organization" => WebhookIssuesOpenedIssueMilestoneCreatorType.Organization,
                "Mannequin" => WebhookIssuesOpenedIssueMilestoneCreatorType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}