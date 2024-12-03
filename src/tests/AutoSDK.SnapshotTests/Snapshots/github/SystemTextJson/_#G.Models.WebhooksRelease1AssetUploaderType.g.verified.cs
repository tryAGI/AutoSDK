//HintName: G.Models.WebhooksRelease1AssetUploaderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksRelease1AssetUploaderType
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
    public static class WebhooksRelease1AssetUploaderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksRelease1AssetUploaderType value)
        {
            return value switch
            {
                WebhooksRelease1AssetUploaderType.Bot => "Bot",
                WebhooksRelease1AssetUploaderType.User => "User",
                WebhooksRelease1AssetUploaderType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksRelease1AssetUploaderType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksRelease1AssetUploaderType.Bot,
                "User" => WebhooksRelease1AssetUploaderType.User,
                "Organization" => WebhooksRelease1AssetUploaderType.Organization,
                _ => null,
            };
        }
    }
}