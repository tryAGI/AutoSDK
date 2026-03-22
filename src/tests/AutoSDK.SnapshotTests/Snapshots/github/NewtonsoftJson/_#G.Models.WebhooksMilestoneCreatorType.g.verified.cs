//HintName: G.Models.WebhooksMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksMilestoneCreatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Mannequin")]
        Mannequin,
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
    public static class WebhooksMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksMilestoneCreatorType value)
        {
            return value switch
            {
                WebhooksMilestoneCreatorType.Bot => "Bot",
                WebhooksMilestoneCreatorType.Mannequin => "Mannequin",
                WebhooksMilestoneCreatorType.Organization => "Organization",
                WebhooksMilestoneCreatorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksMilestoneCreatorType.Bot,
                "Mannequin" => WebhooksMilestoneCreatorType.Mannequin,
                "Organization" => WebhooksMilestoneCreatorType.Organization,
                "User" => WebhooksMilestoneCreatorType.User,
                _ => null,
            };
        }
    }
}