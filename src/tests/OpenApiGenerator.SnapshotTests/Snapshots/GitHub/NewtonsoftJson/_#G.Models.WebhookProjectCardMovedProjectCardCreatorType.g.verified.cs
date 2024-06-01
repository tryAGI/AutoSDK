//HintName: G.Models.WebhookProjectCardMovedProjectCardCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookProjectCardMovedProjectCardCreatorType
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Mannequin")]
        Mannequin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookProjectCardMovedProjectCardCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookProjectCardMovedProjectCardCreatorType value)
        {
            return value switch
            {
                WebhookProjectCardMovedProjectCardCreatorType.Bot => "Bot",
                WebhookProjectCardMovedProjectCardCreatorType.User => "User",
                WebhookProjectCardMovedProjectCardCreatorType.Organization => "Organization",
                WebhookProjectCardMovedProjectCardCreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookProjectCardMovedProjectCardCreatorType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookProjectCardMovedProjectCardCreatorType.Bot,
                "User" => WebhookProjectCardMovedProjectCardCreatorType.User,
                "Organization" => WebhookProjectCardMovedProjectCardCreatorType.Organization,
                "Mannequin" => WebhookProjectCardMovedProjectCardCreatorType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}