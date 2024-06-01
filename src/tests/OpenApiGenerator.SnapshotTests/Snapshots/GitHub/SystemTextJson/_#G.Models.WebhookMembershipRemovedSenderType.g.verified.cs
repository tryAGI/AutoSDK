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
        User,
        /// <summary>
        /// 
        /// </summary>
        Organization,
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
                WebhookMembershipRemovedSenderType.User => "User",
                WebhookMembershipRemovedSenderType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMembershipRemovedSenderType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookMembershipRemovedSenderType.Bot,
                "User" => WebhookMembershipRemovedSenderType.User,
                "Organization" => WebhookMembershipRemovedSenderType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}