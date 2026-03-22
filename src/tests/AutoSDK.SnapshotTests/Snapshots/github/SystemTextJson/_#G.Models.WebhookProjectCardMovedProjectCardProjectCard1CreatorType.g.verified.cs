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
                WebhookProjectCardMovedProjectCardProjectCard1CreatorType.Mannequin => "Mannequin",
                WebhookProjectCardMovedProjectCardProjectCard1CreatorType.Organization => "Organization",
                WebhookProjectCardMovedProjectCardProjectCard1CreatorType.User => "User",
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
                "Mannequin" => WebhookProjectCardMovedProjectCardProjectCard1CreatorType.Mannequin,
                "Organization" => WebhookProjectCardMovedProjectCardProjectCard1CreatorType.Organization,
                "User" => WebhookProjectCardMovedProjectCardProjectCard1CreatorType.User,
                _ => null,
            };
        }
    }
}