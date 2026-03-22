//HintName: G.Models.ConversationItemType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the item.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationItemType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function_call")]
        FunctionCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function_call_output")]
        FunctionCallOutput,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="message")]
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationItemType value)
        {
            return value switch
            {
                ConversationItemType.FunctionCall => "function_call",
                ConversationItemType.FunctionCallOutput => "function_call_output",
                ConversationItemType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationItemType? ToEnum(string value)
        {
            return value switch
            {
                "function_call" => ConversationItemType.FunctionCall,
                "function_call_output" => ConversationItemType.FunctionCallOutput,
                "message" => ConversationItemType.Message,
                _ => null,
            };
        }
    }
}