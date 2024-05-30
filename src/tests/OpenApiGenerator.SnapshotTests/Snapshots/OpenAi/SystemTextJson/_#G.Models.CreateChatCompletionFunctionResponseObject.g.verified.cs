//HintName: G.Models.CreateChatCompletionFunctionResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `chat.completion`.
    /// </summary>
    public enum CreateChatCompletionFunctionResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        Chatcompletion,
    }

    public static class CreateChatCompletionFunctionResponseObjectExtensions
    {
        public static string ToValueString(this CreateChatCompletionFunctionResponseObject value)
        {
            return value switch
            {
                CreateChatCompletionFunctionResponseObject.Chatcompletion => "chat.completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateChatCompletionFunctionResponseObject ToEnum(string value)
        {
            return value switch
            {
                "chat.completion" => CreateChatCompletionFunctionResponseObject.Chatcompletion,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateChatCompletionFunctionResponseObject ToEnum(int value)
        {
            return value switch
            {
                0 => CreateChatCompletionFunctionResponseObject.Chatcompletion,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}