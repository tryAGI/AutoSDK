//HintName: G.Models.WebhookMembershipAddedSenderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookMembershipAddedSenderType
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
    public static class WebhookMembershipAddedSenderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookMembershipAddedSenderType value)
        {
            return value switch
            {
                WebhookMembershipAddedSenderType.Bot => "Bot",
                WebhookMembershipAddedSenderType.User => "User",
                WebhookMembershipAddedSenderType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMembershipAddedSenderType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookMembershipAddedSenderType.Bot,
                "User" => WebhookMembershipAddedSenderType.User,
                "Organization" => WebhookMembershipAddedSenderType.Organization,
                _ => null,
            };
        }
    }
}