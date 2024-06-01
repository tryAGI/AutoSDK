//HintName: G.Models.WebhookPackageUpdatedPackagePackageVersionAuthorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPackageUpdatedPackagePackageVersionAuthorType
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
    public static class WebhookPackageUpdatedPackagePackageVersionAuthorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPackageUpdatedPackagePackageVersionAuthorType value)
        {
            return value switch
            {
                WebhookPackageUpdatedPackagePackageVersionAuthorType.Bot => "Bot",
                WebhookPackageUpdatedPackagePackageVersionAuthorType.User => "User",
                WebhookPackageUpdatedPackagePackageVersionAuthorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPackageUpdatedPackagePackageVersionAuthorType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPackageUpdatedPackagePackageVersionAuthorType.Bot,
                "User" => WebhookPackageUpdatedPackagePackageVersionAuthorType.User,
                "Organization" => WebhookPackageUpdatedPackagePackageVersionAuthorType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}