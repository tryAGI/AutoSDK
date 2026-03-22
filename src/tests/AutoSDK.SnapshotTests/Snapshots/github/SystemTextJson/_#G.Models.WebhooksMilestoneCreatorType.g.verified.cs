//HintName: G.Models.WebhooksMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksMilestoneCreatorType
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
    public static class WebhooksMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksMilestoneCreatorType value)
        {
            return value switch
            {
                WebhooksMilestoneCreatorType.Bot => "Bot",
                WebhooksMilestoneCreatorType.Mannequin => "Mannequin",
                WebhooksMilestoneCreatorType.Organization => "Organization",
                WebhooksMilestoneCreatorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksMilestoneCreatorType.Bot,
                "Mannequin" => WebhooksMilestoneCreatorType.Mannequin,
                "Organization" => WebhooksMilestoneCreatorType.Organization,
                "User" => WebhooksMilestoneCreatorType.User,
                _ => null,
            };
        }
    }
}