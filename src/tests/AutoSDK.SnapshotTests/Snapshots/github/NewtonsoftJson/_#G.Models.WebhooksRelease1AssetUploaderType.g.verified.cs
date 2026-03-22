//HintName: G.Models.WebhooksRelease1AssetUploaderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksRelease1AssetUploaderType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
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
                WebhooksRelease1AssetUploaderType.Organization => "Organization",
                WebhooksRelease1AssetUploaderType.User => "User",
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
                "Organization" => WebhooksRelease1AssetUploaderType.Organization,
                "User" => WebhooksRelease1AssetUploaderType.User,
                _ => null,
            };
        }
    }
}