//HintName: G.Models.WebhookPackagePublishedPackagePackageVersionReleaseAuthorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPackagePublishedPackagePackageVersionReleaseAuthorType
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
    public static class WebhookPackagePublishedPackagePackageVersionReleaseAuthorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPackagePublishedPackagePackageVersionReleaseAuthorType value)
        {
            return value switch
            {
                WebhookPackagePublishedPackagePackageVersionReleaseAuthorType.Bot => "Bot",
                WebhookPackagePublishedPackagePackageVersionReleaseAuthorType.User => "User",
                WebhookPackagePublishedPackagePackageVersionReleaseAuthorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPackagePublishedPackagePackageVersionReleaseAuthorType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPackagePublishedPackagePackageVersionReleaseAuthorType.Bot,
                "User" => WebhookPackagePublishedPackagePackageVersionReleaseAuthorType.User,
                "Organization" => WebhookPackagePublishedPackagePackageVersionReleaseAuthorType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}