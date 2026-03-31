//HintName: G.Models.TriggerEventTypeChatStart.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TriggerEventTypeChatStart
    {
        /// <summary>
        /// 
        /// </summary>
        ChatStart,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TriggerEventTypeChatStartExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TriggerEventTypeChatStart value)
        {
            return value switch
            {
                TriggerEventTypeChatStart.ChatStart => "chat/start",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TriggerEventTypeChatStart? ToEnum(string value)
        {
            return value switch
            {
                "chat/start" => TriggerEventTypeChatStart.ChatStart,
                _ => null,
            };
        }
    }
}