//HintName: G.Models.WebhooksReleaseAuthorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksReleaseAuthorType
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
    public static class WebhooksReleaseAuthorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksReleaseAuthorType value)
        {
            return value switch
            {
                WebhooksReleaseAuthorType.Bot => "Bot",
                WebhooksReleaseAuthorType.User => "User",
                WebhooksReleaseAuthorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksReleaseAuthorType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksReleaseAuthorType.Bot,
                "User" => WebhooksReleaseAuthorType.User,
                "Organization" => WebhooksReleaseAuthorType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}