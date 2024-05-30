//HintName: G.Models.CreateChatCompletionStreamResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `chat.completion.chunk`.
    /// </summary>
    public enum CreateChatCompletionStreamResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        Chatcompletionchunk,
    }

    public static class CreateChatCompletionStreamResponseObjectExtensions
    {
        public static string ToValueString(this CreateChatCompletionStreamResponseObject value)
        {
            return value switch
            {
                CreateChatCompletionStreamResponseObject.Chatcompletionchunk => "chat.completion.chunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateChatCompletionStreamResponseObject ToEnum(string value)
        {
            return value switch
            {
                "chat.completion.chunk" => CreateChatCompletionStreamResponseObject.Chatcompletionchunk,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateChatCompletionStreamResponseObject ToEnum(int value)
        {
            return value switch
            {
                0 => CreateChatCompletionStreamResponseObject.Chatcompletionchunk,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}