//HintName: G.Models.WebhooksAlertDismisserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksAlertDismisserType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksAlertDismisserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksAlertDismisserType value)
        {
            return value switch
            {
                WebhooksAlertDismisserType.Bot => "Bot",
                WebhooksAlertDismisserType.Organization => "Organization",
                WebhooksAlertDismisserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksAlertDismisserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksAlertDismisserType.Bot,
                "Organization" => WebhooksAlertDismisserType.Organization,
                "User" => WebhooksAlertDismisserType.User,
                _ => null,
            };
        }
    }
}