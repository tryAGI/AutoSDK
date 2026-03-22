//HintName: G.Models.WebhookPageBuildBuildPusherType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPageBuildBuildPusherType
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
    public static class WebhookPageBuildBuildPusherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPageBuildBuildPusherType value)
        {
            return value switch
            {
                WebhookPageBuildBuildPusherType.Bot => "Bot",
                WebhookPageBuildBuildPusherType.Organization => "Organization",
                WebhookPageBuildBuildPusherType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPageBuildBuildPusherType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPageBuildBuildPusherType.Bot,
                "Organization" => WebhookPageBuildBuildPusherType.Organization,
                "User" => WebhookPageBuildBuildPusherType.User,
                _ => null,
            };
        }
    }
}