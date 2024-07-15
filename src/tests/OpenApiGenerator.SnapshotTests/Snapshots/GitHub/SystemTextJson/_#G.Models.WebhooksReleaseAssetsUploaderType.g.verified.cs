//HintName: G.Models.WebhooksReleaseAssetsUploaderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksReleaseAssetsUploaderType
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
    public static class WebhooksReleaseAssetsUploaderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksReleaseAssetsUploaderType value)
        {
            return value switch
            {
                WebhooksReleaseAssetsUploaderType.Bot => "Bot",
                WebhooksReleaseAssetsUploaderType.User => "User",
                WebhooksReleaseAssetsUploaderType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksReleaseAssetsUploaderType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksReleaseAssetsUploaderType.Bot,
                "User" => WebhooksReleaseAssetsUploaderType.User,
                "Organization" => WebhooksReleaseAssetsUploaderType.Organization,
                _ => null,
            };
        }
    }
}