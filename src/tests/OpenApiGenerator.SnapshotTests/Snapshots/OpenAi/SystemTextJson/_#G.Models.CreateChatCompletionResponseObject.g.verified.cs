//HintName: G.Models.CreateChatCompletionResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `chat.completion`.
    /// </summary>
    public enum CreateChatCompletionResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        Chatcompletion,
    }

    public static class CreateChatCompletionResponseObjectExtensions
    {
        public static string ToValueString(this CreateChatCompletionResponseObject value)
        {
            return value switch
            {
                CreateChatCompletionResponseObject.Chatcompletion => "chat.completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateChatCompletionResponseObject ToEnum(string value)
        {
            return value switch
            {
                "chat.completion" => CreateChatCompletionResponseObject.Chatcompletion,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateChatCompletionResponseObject ToEnum(int value)
        {
            return value switch
            {
                0 => CreateChatCompletionResponseObject.Chatcompletion,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}