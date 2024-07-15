//HintName: G.Models.WebhooksRuleRequiredConversationResolutionLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksRuleRequiredConversationResolutionLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="off")]
        Off,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="non_admins")]
        NonAdmins,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="everyone")]
        Everyone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksRuleRequiredConversationResolutionLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksRuleRequiredConversationResolutionLevel value)
        {
            return value switch
            {
                WebhooksRuleRequiredConversationResolutionLevel.Off => "off",
                WebhooksRuleRequiredConversationResolutionLevel.NonAdmins => "non_admins",
                WebhooksRuleRequiredConversationResolutionLevel.Everyone => "everyone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksRuleRequiredConversationResolutionLevel? ToEnum(string value)
        {
            return value switch
            {
                "off" => WebhooksRuleRequiredConversationResolutionLevel.Off,
                "non_admins" => WebhooksRuleRequiredConversationResolutionLevel.NonAdmins,
                "everyone" => WebhooksRuleRequiredConversationResolutionLevel.Everyone,
                _ => null,
            };
        }
    }
}