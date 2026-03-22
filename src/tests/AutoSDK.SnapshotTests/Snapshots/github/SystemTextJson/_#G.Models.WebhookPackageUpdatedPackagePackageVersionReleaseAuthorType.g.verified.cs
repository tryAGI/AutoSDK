//HintName: G.Models.WebhookPackageUpdatedPackagePackageVersionReleaseAuthorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPackageUpdatedPackagePackageVersionReleaseAuthorType
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
    public static class WebhookPackageUpdatedPackagePackageVersionReleaseAuthorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPackageUpdatedPackagePackageVersionReleaseAuthorType value)
        {
            return value switch
            {
                WebhookPackageUpdatedPackagePackageVersionReleaseAuthorType.Bot => "Bot",
                WebhookPackageUpdatedPackagePackageVersionReleaseAuthorType.Organization => "Organization",
                WebhookPackageUpdatedPackagePackageVersionReleaseAuthorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPackageUpdatedPackagePackageVersionReleaseAuthorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPackageUpdatedPackagePackageVersionReleaseAuthorType.Bot,
                "Organization" => WebhookPackageUpdatedPackagePackageVersionReleaseAuthorType.Organization,
                "User" => WebhookPackageUpdatedPackagePackageVersionReleaseAuthorType.User,
                _ => null,
            };
        }
    }
}