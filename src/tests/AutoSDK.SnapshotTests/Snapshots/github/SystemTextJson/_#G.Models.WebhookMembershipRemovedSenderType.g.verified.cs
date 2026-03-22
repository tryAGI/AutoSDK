//HintName: G.Models.WebhookMembershipRemovedSenderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookMembershipRemovedSenderType
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
    public static class WebhookMembershipRemovedSenderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookMembershipRemovedSenderType value)
        {
            return value switch
            {
                WebhookMembershipRemovedSenderType.Bot => "Bot",
                WebhookMembershipRemovedSenderType.Organization => "Organization",
                WebhookMembershipRemovedSenderType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMembershipRemovedSenderType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookMembershipRemovedSenderType.Bot,
                "Organization" => WebhookMembershipRemovedSenderType.Organization,
                "User" => WebhookMembershipRemovedSenderType.User,
                _ => null,
            };
        }
    }
}