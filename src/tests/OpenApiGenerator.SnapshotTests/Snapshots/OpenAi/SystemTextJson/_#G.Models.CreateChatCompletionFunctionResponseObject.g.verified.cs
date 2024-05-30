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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionFunctionResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionFunctionResponseObject value)
        {
            return value switch
            {
                CreateChatCompletionFunctionResponseObject.Chatcompletion => "chat.completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionFunctionResponseObject ToEnum(string value)
        {
            return value switch
            {
                "chat.completion" => CreateChatCompletionFunctionResponseObject.Chatcompletion,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}