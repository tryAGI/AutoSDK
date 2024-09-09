//HintName: G.Models.WebhooksIssueMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksIssueMilestoneCreatorType
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
    public static class WebhooksIssueMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssueMilestoneCreatorType value)
        {
            return value switch
            {
                WebhooksIssueMilestoneCreatorType.Bot => "Bot",
                WebhooksIssueMilestoneCreatorType.User => "User",
                WebhooksIssueMilestoneCreatorType.Organization => "Organization",
                WebhooksIssueMilestoneCreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssueMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksIssueMilestoneCreatorType.Bot,
                "User" => WebhooksIssueMilestoneCreatorType.User,
                "Organization" => WebhooksIssueMilestoneCreatorType.Organization,
                "Mannequin" => WebhooksIssueMilestoneCreatorType.Mannequin,
                _ => null,
            };
        }
    }
}