//HintName: G.Models.WebhookPackagePublishedPackagePackageVersionAuthorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPackagePublishedPackagePackageVersionAuthorType
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
    public static class WebhookPackagePublishedPackagePackageVersionAuthorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPackagePublishedPackagePackageVersionAuthorType value)
        {
            return value switch
            {
                WebhookPackagePublishedPackagePackageVersionAuthorType.Bot => "Bot",
                WebhookPackagePublishedPackagePackageVersionAuthorType.Organization => "Organization",
                WebhookPackagePublishedPackagePackageVersionAuthorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPackagePublishedPackagePackageVersionAuthorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPackagePublishedPackagePackageVersionAuthorType.Bot,
                "Organization" => WebhookPackagePublishedPackagePackageVersionAuthorType.Organization,
                "User" => WebhookPackagePublishedPackagePackageVersionAuthorType.User,
                _ => null,
            };
        }
    }
}