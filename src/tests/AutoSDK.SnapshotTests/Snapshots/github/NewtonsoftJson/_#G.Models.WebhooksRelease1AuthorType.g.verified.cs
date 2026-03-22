//HintName: G.Models.WebhooksRelease1AuthorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksRelease1AuthorType
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
    public static class WebhooksRelease1AuthorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksRelease1AuthorType value)
        {
            return value switch
            {
                WebhooksRelease1AuthorType.Bot => "Bot",
                WebhooksRelease1AuthorType.Organization => "Organization",
                WebhooksRelease1AuthorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksRelease1AuthorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksRelease1AuthorType.Bot,
                "Organization" => WebhooksRelease1AuthorType.Organization,
                "User" => WebhooksRelease1AuthorType.User,
                _ => null,
            };
        }
    }
}