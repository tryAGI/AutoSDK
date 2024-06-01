//HintName: G.Models.WebhookPackagePublishedPackageOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPackagePublishedPackageOwnerType
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
    public static class WebhookPackagePublishedPackageOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPackagePublishedPackageOwnerType value)
        {
            return value switch
            {
                WebhookPackagePublishedPackageOwnerType.Bot => "Bot",
                WebhookPackagePublishedPackageOwnerType.User => "User",
                WebhookPackagePublishedPackageOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPackagePublishedPackageOwnerType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPackagePublishedPackageOwnerType.Bot,
                "User" => WebhookPackagePublishedPackageOwnerType.User,
                "Organization" => WebhookPackagePublishedPackageOwnerType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}