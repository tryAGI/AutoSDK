//HintName: G.Models.GetTriggersTypesResponseItemType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The trigger mechanism - either webhook (event-based) or poll (scheduled check)<br/>
    /// Example: webhook
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetTriggersTypesResponseItemType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="poll")]
        Poll,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="webhook")]
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTriggersTypesResponseItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTriggersTypesResponseItemType value)
        {
            return value switch
            {
                GetTriggersTypesResponseItemType.Poll => "poll",
                GetTriggersTypesResponseItemType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTriggersTypesResponseItemType? ToEnum(string value)
        {
            return value switch
            {
                "poll" => GetTriggersTypesResponseItemType.Poll,
                "webhook" => GetTriggersTypesResponseItemType.Webhook,
                _ => null,
            };
        }
    }
}