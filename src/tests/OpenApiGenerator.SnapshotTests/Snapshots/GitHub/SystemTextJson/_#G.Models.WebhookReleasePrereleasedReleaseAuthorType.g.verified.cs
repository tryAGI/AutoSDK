//HintName: G.Models.WebhookReleasePrereleasedReleaseAuthorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookReleasePrereleasedReleaseAuthorType
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
    public static class WebhookReleasePrereleasedReleaseAuthorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookReleasePrereleasedReleaseAuthorType value)
        {
            return value switch
            {
                WebhookReleasePrereleasedReleaseAuthorType.Bot => "Bot",
                WebhookReleasePrereleasedReleaseAuthorType.User => "User",
                WebhookReleasePrereleasedReleaseAuthorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookReleasePrereleasedReleaseAuthorType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookReleasePrereleasedReleaseAuthorType.Bot,
                "User" => WebhookReleasePrereleasedReleaseAuthorType.User,
                "Organization" => WebhookReleasePrereleasedReleaseAuthorType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}