//HintName: G.Models.ChatCompletionNamedToolChoiceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the tool. Currently, only `function` is supported.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionNamedToolChoiceType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
    }

    public static class ChatCompletionNamedToolChoiceTypeExtensions
    {
        public static string ToValueString(this ChatCompletionNamedToolChoiceType value)
        {
            return value switch
            {
                ChatCompletionNamedToolChoiceType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChatCompletionNamedToolChoiceType ToEnum(string value)
        {
            return value switch
            {
                "function" => ChatCompletionNamedToolChoiceType.Function,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChatCompletionNamedToolChoiceType ToEnum(int value)
        {
            return value switch
            {
                0 => ChatCompletionNamedToolChoiceType.Function,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}