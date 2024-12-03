//HintName: G.Models.WebhookIssuesDemilestonedIssueMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesDemilestonedIssueMilestoneCreatorType
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
    public static class WebhookIssuesDemilestonedIssueMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDemilestonedIssueMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookIssuesDemilestonedIssueMilestoneCreatorType.Bot => "Bot",
                WebhookIssuesDemilestonedIssueMilestoneCreatorType.User => "User",
                WebhookIssuesDemilestonedIssueMilestoneCreatorType.Organization => "Organization",
                WebhookIssuesDemilestonedIssueMilestoneCreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDemilestonedIssueMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesDemilestonedIssueMilestoneCreatorType.Bot,
                "User" => WebhookIssuesDemilestonedIssueMilestoneCreatorType.User,
                "Organization" => WebhookIssuesDemilestonedIssueMilestoneCreatorType.Organization,
                "Mannequin" => WebhookIssuesDemilestonedIssueMilestoneCreatorType.Mannequin,
                _ => null,
            };
        }
    }
}