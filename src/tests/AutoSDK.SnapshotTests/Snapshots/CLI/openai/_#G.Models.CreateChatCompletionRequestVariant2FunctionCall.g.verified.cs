//HintName: G.Models.CreateChatCompletionRequestVariant2FunctionCall.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `none` means the model will not call a function and instead generates a message. `auto` means the model can pick between generating a message or calling a function.
    /// </summary>
    public enum CreateChatCompletionRequestVariant2FunctionCall
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionRequestVariant2FunctionCallExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionRequestVariant2FunctionCall value)
        {
            return value switch
            {
                CreateChatCompletionRequestVariant2FunctionCall.None => "none",
                CreateChatCompletionRequestVariant2FunctionCall.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionRequestVariant2FunctionCall? ToEnum(string value)
        {
            return value switch
            {
                "none" => CreateChatCompletionRequestVariant2FunctionCall.None,
                "auto" => CreateChatCompletionRequestVariant2FunctionCall.Auto,
                _ => null,
            };
        }
    }
}