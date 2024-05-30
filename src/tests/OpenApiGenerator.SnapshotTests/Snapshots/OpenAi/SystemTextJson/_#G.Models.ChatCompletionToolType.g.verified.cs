//HintName: G.Models.ChatCompletionToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the tool. Currently, only `function` is supported.
    /// </summary>
    public enum ChatCompletionToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    public static class ChatCompletionToolTypeExtensions
    {
        public static string ToValueString(this ChatCompletionToolType value)
        {
            return value switch
            {
                ChatCompletionToolType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChatCompletionToolType ToEnum(string value)
        {
            return value switch
            {
                "function" => ChatCompletionToolType.Function,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChatCompletionToolType ToEnum(int value)
        {
            return value switch
            {
                0 => ChatCompletionToolType.Function,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}