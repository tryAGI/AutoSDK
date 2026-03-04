//HintName: G.Models.WebhookProjectCardMovedProjectCardProjectCard1CreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookProjectCardMovedProjectCardProjectCard1CreatorType
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
    public static class WebhookProjectCardMovedProjectCardProjectCard1CreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookProjectCardMovedProjectCardProjectCard1CreatorType value)
        {
            return value switch
            {
                WebhookProjectCardMovedProjectCardProjectCard1CreatorType.Bot => "Bot",
                WebhookProjectCardMovedProjectCardProjectCard1CreatorType.User => "User",
                WebhookProjectCardMovedProjectCardProjectCard1CreatorType.Organization => "Organization",
                WebhookProjectCardMovedProjectCardProjectCard1CreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookProjectCardMovedProjectCardProjectCard1CreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookProjectCardMovedProjectCardProjectCard1CreatorType.Bot,
                "User" => WebhookProjectCardMovedProjectCardProjectCard1CreatorType.User,
                "Organization" => WebhookProjectCardMovedProjectCardProjectCard1CreatorType.Organization,
                "Mannequin" => WebhookProjectCardMovedProjectCardProjectCard1CreatorType.Mannequin,
                _ => null,
            };
        }
    }
}