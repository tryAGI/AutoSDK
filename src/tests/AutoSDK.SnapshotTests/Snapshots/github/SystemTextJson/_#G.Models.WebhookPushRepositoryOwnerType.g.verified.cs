//HintName: G.Models.WebhookPushRepositoryOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPushRepositoryOwnerType
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
    public static class WebhookPushRepositoryOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPushRepositoryOwnerType value)
        {
            return value switch
            {
                WebhookPushRepositoryOwnerType.Bot => "Bot",
                WebhookPushRepositoryOwnerType.Organization => "Organization",
                WebhookPushRepositoryOwnerType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPushRepositoryOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPushRepositoryOwnerType.Bot,
                "Organization" => WebhookPushRepositoryOwnerType.Organization,
                "User" => WebhookPushRepositoryOwnerType.User,
                _ => null,
            };
        }
    }
}