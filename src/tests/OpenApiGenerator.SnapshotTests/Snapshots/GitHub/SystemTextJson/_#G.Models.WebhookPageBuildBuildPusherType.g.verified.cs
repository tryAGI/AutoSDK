//HintName: G.Models.WebhookPageBuildBuildPusherType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPageBuildBuildPusherType
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
    public static class WebhookPageBuildBuildPusherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPageBuildBuildPusherType value)
        {
            return value switch
            {
                WebhookPageBuildBuildPusherType.Bot => "Bot",
                WebhookPageBuildBuildPusherType.User => "User",
                WebhookPageBuildBuildPusherType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPageBuildBuildPusherType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPageBuildBuildPusherType.Bot,
                "User" => WebhookPageBuildBuildPusherType.User,
                "Organization" => WebhookPageBuildBuildPusherType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}