//HintName: G.Models.WebhooksRelease1AssetsUploaderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksRelease1AssetsUploaderType
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
    public static class WebhooksRelease1AssetsUploaderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksRelease1AssetsUploaderType value)
        {
            return value switch
            {
                WebhooksRelease1AssetsUploaderType.Bot => "Bot",
                WebhooksRelease1AssetsUploaderType.User => "User",
                WebhooksRelease1AssetsUploaderType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksRelease1AssetsUploaderType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksRelease1AssetsUploaderType.Bot,
                "User" => WebhooksRelease1AssetsUploaderType.User,
                "Organization" => WebhooksRelease1AssetsUploaderType.Organization,
                _ => null,
            };
        }
    }
}