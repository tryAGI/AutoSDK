//HintName: G.Models.WebhookIssuesEditedIssueMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesEditedIssueMilestoneCreatorType
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
    public static class WebhookIssuesEditedIssueMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesEditedIssueMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookIssuesEditedIssueMilestoneCreatorType.Bot => "Bot",
                WebhookIssuesEditedIssueMilestoneCreatorType.User => "User",
                WebhookIssuesEditedIssueMilestoneCreatorType.Organization => "Organization",
                WebhookIssuesEditedIssueMilestoneCreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesEditedIssueMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesEditedIssueMilestoneCreatorType.Bot,
                "User" => WebhookIssuesEditedIssueMilestoneCreatorType.User,
                "Organization" => WebhookIssuesEditedIssueMilestoneCreatorType.Organization,
                "Mannequin" => WebhookIssuesEditedIssueMilestoneCreatorType.Mannequin,
                _ => null,
            };
        }
    }
}