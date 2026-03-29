//HintName: G.Models.TriggerEventDataVariant2EventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TriggerEventDataVariant2EventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chat/start")]
        ChatStart,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TriggerEventDataVariant2EventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TriggerEventDataVariant2EventType value)
        {
            return value switch
            {
                TriggerEventDataVariant2EventType.ChatStart => "chat/start",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TriggerEventDataVariant2EventType? ToEnum(string value)
        {
            return value switch
            {
                "chat/start" => TriggerEventDataVariant2EventType.ChatStart,
                _ => null,
            };
        }
    }
}