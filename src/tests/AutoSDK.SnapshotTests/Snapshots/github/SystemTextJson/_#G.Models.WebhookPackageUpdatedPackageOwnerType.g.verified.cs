//HintName: G.Models.WebhookPackageUpdatedPackageOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPackageUpdatedPackageOwnerType
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
    public static class WebhookPackageUpdatedPackageOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPackageUpdatedPackageOwnerType value)
        {
            return value switch
            {
                WebhookPackageUpdatedPackageOwnerType.Bot => "Bot",
                WebhookPackageUpdatedPackageOwnerType.Organization => "Organization",
                WebhookPackageUpdatedPackageOwnerType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPackageUpdatedPackageOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPackageUpdatedPackageOwnerType.Bot,
                "Organization" => WebhookPackageUpdatedPackageOwnerType.Organization,
                "User" => WebhookPackageUpdatedPackageOwnerType.User,
                _ => null,
            };
        }
    }
}