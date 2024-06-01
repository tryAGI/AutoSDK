//HintName: G.Models.WebhookIssuesClosedIssueMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesClosedIssueMilestoneCreatorType
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
    public static class WebhookIssuesClosedIssueMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueMilestoneCreatorType.Bot => "Bot",
                WebhookIssuesClosedIssueMilestoneCreatorType.User => "User",
                WebhookIssuesClosedIssueMilestoneCreatorType.Organization => "Organization",
                WebhookIssuesClosedIssueMilestoneCreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueMilestoneCreatorType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesClosedIssueMilestoneCreatorType.Bot,
                "User" => WebhookIssuesClosedIssueMilestoneCreatorType.User,
                "Organization" => WebhookIssuesClosedIssueMilestoneCreatorType.Organization,
                "Mannequin" => WebhookIssuesClosedIssueMilestoneCreatorType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}