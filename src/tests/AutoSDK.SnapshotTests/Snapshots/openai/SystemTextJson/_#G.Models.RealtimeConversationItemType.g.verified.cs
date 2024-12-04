//HintName: G.Models.RealtimeConversationItemType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the item (`message`, `function_call`, `function_call_output`).
    /// </summary>
    public enum RealtimeConversationItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Message,
        /// <summary>
        /// 
        /// </summary>
        FunctionCall,
        /// <summary>
        /// 
        /// </summary>
        FunctionCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemType value)
        {
            return value switch
            {
                RealtimeConversationItemType.Message => "message",
                RealtimeConversationItemType.FunctionCall => "function_call",
                RealtimeConversationItemType.FunctionCallOutput => "function_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemType? ToEnum(string value)
        {
            return value switch
            {
                "message" => RealtimeConversationItemType.Message,
                "function_call" => RealtimeConversationItemType.FunctionCall,
                "function_call_output" => RealtimeConversationItemType.FunctionCallOutput,
                _ => null,
            };
        }
    }
}