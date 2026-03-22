//HintName: G.Models.WebhookPackagePublishedPackageOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPackagePublishedPackageOwnerType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
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
    public static class WebhookPackagePublishedPackageOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPackagePublishedPackageOwnerType value)
        {
            return value switch
            {
                WebhookPackagePublishedPackageOwnerType.Bot => "Bot",
                WebhookPackagePublishedPackageOwnerType.Organization => "Organization",
                WebhookPackagePublishedPackageOwnerType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPackagePublishedPackageOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPackagePublishedPackageOwnerType.Bot,
                "Organization" => WebhookPackagePublishedPackageOwnerType.Organization,
                "User" => WebhookPackagePublishedPackageOwnerType.User,
                _ => null,
            };
        }
    }
}