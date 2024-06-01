//HintName: G.Models.WebhookProjectCardDeletedProjectCardCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookProjectCardDeletedProjectCardCreatorType
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
    public static class WebhookProjectCardDeletedProjectCardCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookProjectCardDeletedProjectCardCreatorType value)
        {
            return value switch
            {
                WebhookProjectCardDeletedProjectCardCreatorType.Bot => "Bot",
                WebhookProjectCardDeletedProjectCardCreatorType.User => "User",
                WebhookProjectCardDeletedProjectCardCreatorType.Organization => "Organization",
                WebhookProjectCardDeletedProjectCardCreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookProjectCardDeletedProjectCardCreatorType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookProjectCardDeletedProjectCardCreatorType.Bot,
                "User" => WebhookProjectCardDeletedProjectCardCreatorType.User,
                "Organization" => WebhookProjectCardDeletedProjectCardCreatorType.Organization,
                "Mannequin" => WebhookProjectCardDeletedProjectCardCreatorType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}