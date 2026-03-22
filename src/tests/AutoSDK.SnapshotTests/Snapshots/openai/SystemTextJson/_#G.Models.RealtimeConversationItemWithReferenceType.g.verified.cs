//HintName: G.Models.RealtimeConversationItemWithReferenceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the item (`message`, `function_call`, `function_call_output`, `item_reference`).
    /// </summary>
    public enum RealtimeConversationItemWithReferenceType
    {
        /// <summary>
        /// 
        /// </summary>
        FunctionCall,
        /// <summary>
        /// 
        /// </summary>
        FunctionCallOutput,
        /// <summary>
        /// 
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationItemWithReferenceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemWithReferenceType value)
        {
            return value switch
            {
                RealtimeConversationItemWithReferenceType.FunctionCall => "function_call",
                RealtimeConversationItemWithReferenceType.FunctionCallOutput => "function_call_output",
                RealtimeConversationItemWithReferenceType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemWithReferenceType? ToEnum(string value)
        {
            return value switch
            {
                "function_call" => RealtimeConversationItemWithReferenceType.FunctionCall,
                "function_call_output" => RealtimeConversationItemWithReferenceType.FunctionCallOutput,
                "message" => RealtimeConversationItemWithReferenceType.Message,
                _ => null,
            };
        }
    }
}