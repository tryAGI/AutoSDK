//HintName: G.Models.WebhooksSponsorshipSponsorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksSponsorshipSponsorType
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
    public static class WebhooksSponsorshipSponsorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksSponsorshipSponsorType value)
        {
            return value switch
            {
                WebhooksSponsorshipSponsorType.Bot => "Bot",
                WebhooksSponsorshipSponsorType.User => "User",
                WebhooksSponsorshipSponsorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksSponsorshipSponsorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksSponsorshipSponsorType.Bot,
                "User" => WebhooksSponsorshipSponsorType.User,
                "Organization" => WebhooksSponsorshipSponsorType.Organization,
                _ => null,
            };
        }
    }
}