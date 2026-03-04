//HintName: G.Models.WebhookProjectCardMovedProjectCardProjectCard1CreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookProjectCardMovedProjectCardProjectCard1CreatorType
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
    public static class WebhookProjectCardMovedProjectCardProjectCard1CreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookProjectCardMovedProjectCardProjectCard1CreatorType value)
        {
            return value switch
            {
                WebhookProjectCardMovedProjectCardProjectCard1CreatorType.Bot => "Bot",
                WebhookProjectCardMovedProjectCardProjectCard1CreatorType.User => "User",
                WebhookProjectCardMovedProjectCardProjectCard1CreatorType.Organization => "Organization",
                WebhookProjectCardMovedProjectCardProjectCard1CreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookProjectCardMovedProjectCardProjectCard1CreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookProjectCardMovedProjectCardProjectCard1CreatorType.Bot,
                "User" => WebhookProjectCardMovedProjectCardProjectCard1CreatorType.User,
                "Organization" => WebhookProjectCardMovedProjectCardProjectCard1CreatorType.Organization,
                "Mannequin" => WebhookProjectCardMovedProjectCardProjectCard1CreatorType.Mannequin,
                _ => null,
            };
        }
    }
}