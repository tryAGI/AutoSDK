//HintName: G.Models.WebhookProjectCardMovedProjectCardVariant1CreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookProjectCardMovedProjectCardVariant1CreatorType
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
    public static class WebhookProjectCardMovedProjectCardVariant1CreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookProjectCardMovedProjectCardVariant1CreatorType value)
        {
            return value switch
            {
                WebhookProjectCardMovedProjectCardVariant1CreatorType.Bot => "Bot",
                WebhookProjectCardMovedProjectCardVariant1CreatorType.User => "User",
                WebhookProjectCardMovedProjectCardVariant1CreatorType.Organization => "Organization",
                WebhookProjectCardMovedProjectCardVariant1CreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookProjectCardMovedProjectCardVariant1CreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookProjectCardMovedProjectCardVariant1CreatorType.Bot,
                "User" => WebhookProjectCardMovedProjectCardVariant1CreatorType.User,
                "Organization" => WebhookProjectCardMovedProjectCardVariant1CreatorType.Organization,
                "Mannequin" => WebhookProjectCardMovedProjectCardVariant1CreatorType.Mannequin,
                _ => null,
            };
        }
    }
}