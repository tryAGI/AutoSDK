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
        Organization,
        /// <summary>
        /// 
        /// </summary>
        User,
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
                WebhooksProjectCardCreatorType.Organization => "Organization",
                WebhooksProjectCardCreatorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksProjectCardCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksProjectCardCreatorType.Bot,
                "Organization" => WebhooksProjectCardCreatorType.Organization,
                "User" => WebhooksProjectCardCreatorType.User,
                _ => null,
            };
        }
    }
}