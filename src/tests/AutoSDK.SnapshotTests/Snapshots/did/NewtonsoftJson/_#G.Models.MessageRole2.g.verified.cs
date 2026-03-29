//HintName: G.Models.MessageRole2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageRole2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="system")]
        System,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
        Tool,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageRole2 value)
        {
            return value switch
            {
                MessageRole2.Assistant => "assistant",
                MessageRole2.Function => "function",
                MessageRole2.System => "system",
                MessageRole2.Tool => "tool",
                MessageRole2.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageRole2? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => MessageRole2.Assistant,
                "function" => MessageRole2.Function,
                "system" => MessageRole2.System,
                "tool" => MessageRole2.Tool,
                "user" => MessageRole2.User,
                _ => null,
            };
        }
    }
}