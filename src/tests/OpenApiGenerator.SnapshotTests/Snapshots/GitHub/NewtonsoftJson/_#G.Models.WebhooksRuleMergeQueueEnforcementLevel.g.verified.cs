//HintName: G.Models.WebhooksRuleMergeQueueEnforcementLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksRuleMergeQueueEnforcementLevel
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
    public static class WebhooksRuleMergeQueueEnforcementLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksRuleMergeQueueEnforcementLevel value)
        {
            return value switch
            {
                WebhooksRuleMergeQueueEnforcementLevel.Off => "off",
                WebhooksRuleMergeQueueEnforcementLevel.NonAdmins => "non_admins",
                WebhooksRuleMergeQueueEnforcementLevel.Everyone => "everyone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksRuleMergeQueueEnforcementLevel ToEnum(string value)
        {
            return value switch
            {
                "off" => WebhooksRuleMergeQueueEnforcementLevel.Off,
                "non_admins" => WebhooksRuleMergeQueueEnforcementLevel.NonAdmins,
                "everyone" => WebhooksRuleMergeQueueEnforcementLevel.Everyone,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}