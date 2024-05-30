//HintName: G.Models.ChatCompletionMessageToolCallType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the tool. Currently, only `function` is supported.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionMessageToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
    }

    public static class ChatCompletionMessageToolCallTypeExtensions
    {
        public static string ToValueString(this ChatCompletionMessageToolCallType value)
        {
            return value switch
            {
                ChatCompletionMessageToolCallType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChatCompletionMessageToolCallType ToEnum(string value)
        {
            return value switch
            {
                "function" => ChatCompletionMessageToolCallType.Function,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChatCompletionMessageToolCallType ToEnum(int value)
        {
            return value switch
            {
                0 => ChatCompletionMessageToolCallType.Function,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}