//HintName: G.Models.CreateChatCompletionStreamResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `chat.completion.chunk`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateChatCompletionStreamResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chat.completion.chunk")]
        Chatcompletionchunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionStreamResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionStreamResponseObject value)
        {
            return value switch
            {
                CreateChatCompletionStreamResponseObject.Chatcompletionchunk => "chat.completion.chunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionStreamResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "chat.completion.chunk" => CreateChatCompletionStreamResponseObject.Chatcompletionchunk,
                _ => null,
            };
        }
    }
}