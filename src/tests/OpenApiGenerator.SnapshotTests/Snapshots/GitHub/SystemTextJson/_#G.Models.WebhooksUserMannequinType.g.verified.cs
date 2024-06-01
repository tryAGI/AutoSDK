//HintName: G.Models.WebhooksUserMannequinType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksUserMannequinType
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
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksUserMannequinTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksUserMannequinType value)
        {
            return value switch
            {
                WebhooksUserMannequinType.Bot => "Bot",
                WebhooksUserMannequinType.User => "User",
                WebhooksUserMannequinType.Organization => "Organization",
                WebhooksUserMannequinType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksUserMannequinType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksUserMannequinType.Bot,
                "User" => WebhooksUserMannequinType.User,
                "Organization" => WebhooksUserMannequinType.Organization,
                "Mannequin" => WebhooksUserMannequinType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}