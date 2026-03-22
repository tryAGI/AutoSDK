//HintName: G.Models.WebhooksReleaseAssetUploaderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksReleaseAssetUploaderType
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
    public static class WebhooksReleaseAssetUploaderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksReleaseAssetUploaderType value)
        {
            return value switch
            {
                WebhooksReleaseAssetUploaderType.Bot => "Bot",
                WebhooksReleaseAssetUploaderType.Organization => "Organization",
                WebhooksReleaseAssetUploaderType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksReleaseAssetUploaderType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksReleaseAssetUploaderType.Bot,
                "Organization" => WebhooksReleaseAssetUploaderType.Organization,
                "User" => WebhooksReleaseAssetUploaderType.User,
                _ => null,
            };
        }
    }
}