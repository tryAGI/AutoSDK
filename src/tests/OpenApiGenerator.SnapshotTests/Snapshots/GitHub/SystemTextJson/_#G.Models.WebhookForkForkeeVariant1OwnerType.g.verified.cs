//HintName: G.Models.WebhookForkForkeeVariant1OwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookForkForkeeVariant1OwnerType
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookForkForkeeVariant1OwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookForkForkeeVariant1OwnerType value)
        {
            return value switch
            {
                WebhookForkForkeeVariant1OwnerType.Bot => "Bot",
                WebhookForkForkeeVariant1OwnerType.User => "User",
                WebhookForkForkeeVariant1OwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookForkForkeeVariant1OwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookForkForkeeVariant1OwnerType.Bot,
                "User" => WebhookForkForkeeVariant1OwnerType.User,
                "Organization" => WebhookForkForkeeVariant1OwnerType.Organization,
                _ => null,
            };
        }
    }
}