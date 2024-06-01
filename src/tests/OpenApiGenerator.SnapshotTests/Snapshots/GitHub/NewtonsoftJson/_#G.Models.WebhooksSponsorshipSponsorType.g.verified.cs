//HintName: G.Models.WebhooksSponsorshipSponsorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksSponsorshipSponsorType
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
        public static WebhooksSponsorshipSponsorType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksSponsorshipSponsorType.Bot,
                "User" => WebhooksSponsorshipSponsorType.User,
                "Organization" => WebhooksSponsorshipSponsorType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}