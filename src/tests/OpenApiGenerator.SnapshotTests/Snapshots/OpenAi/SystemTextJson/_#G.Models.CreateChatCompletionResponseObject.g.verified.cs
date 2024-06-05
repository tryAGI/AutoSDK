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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionResponseObject value)
        {
            return value switch
            {
                CreateChatCompletionResponseObject.Chatcompletion => "chat.completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "chat.completion" => CreateChatCompletionResponseObject.Chatcompletion,
                _ => null,
            };
        }
    }
}