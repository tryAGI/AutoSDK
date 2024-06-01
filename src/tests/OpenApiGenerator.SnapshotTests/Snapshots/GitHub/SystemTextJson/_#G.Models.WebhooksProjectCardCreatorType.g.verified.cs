//HintName: G.Models.WebhooksProjectCardCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksProjectCardCreatorType
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
    public static class WebhooksProjectCardCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksProjectCardCreatorType value)
        {
            return value switch
            {
                WebhooksProjectCardCreatorType.Bot => "Bot",
                WebhooksProjectCardCreatorType.User => "User",
                WebhooksProjectCardCreatorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksProjectCardCreatorType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksProjectCardCreatorType.Bot,
                "User" => WebhooksProjectCardCreatorType.User,
                "Organization" => WebhooksProjectCardCreatorType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}