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
        Organization,
        /// <summary>
        /// 
        /// </summary>
        User,
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
                WebhooksReleaseAuthorType.Organization => "Organization",
                WebhooksReleaseAuthorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksReleaseAuthorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksReleaseAuthorType.Bot,
                "Organization" => WebhooksReleaseAuthorType.Organization,
                "User" => WebhooksReleaseAuthorType.User,
                _ => null,
            };
        }
    }
}