//HintName: G.Models.WebhooksReleaseAssetUploaderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksReleaseAssetUploaderType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
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
                WebhooksReleaseAssetUploaderType.User => "User",
                WebhooksReleaseAssetUploaderType.Organization => "Organization",
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
                "User" => WebhooksReleaseAssetUploaderType.User,
                "Organization" => WebhooksReleaseAssetUploaderType.Organization,
                _ => null,
            };
        }
    }
}