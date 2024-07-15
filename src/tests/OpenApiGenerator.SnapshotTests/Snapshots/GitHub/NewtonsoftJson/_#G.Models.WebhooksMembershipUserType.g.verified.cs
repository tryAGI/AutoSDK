//HintName: G.Models.WebhooksMembershipUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksMembershipUserType
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
    public static class WebhooksMembershipUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksMembershipUserType value)
        {
            return value switch
            {
                WebhooksMembershipUserType.Bot => "Bot",
                WebhooksMembershipUserType.User => "User",
                WebhooksMembershipUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksMembershipUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksMembershipUserType.Bot,
                "User" => WebhooksMembershipUserType.User,
                "Organization" => WebhooksMembershipUserType.Organization,
                _ => null,
            };
        }
    }
}