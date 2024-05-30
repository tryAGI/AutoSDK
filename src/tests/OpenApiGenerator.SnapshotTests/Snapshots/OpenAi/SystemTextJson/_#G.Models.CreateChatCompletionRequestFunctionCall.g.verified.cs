//HintName: G.Models.CreateChatCompletionRequestFunctionCall.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `none` means the model will not call a function and instead generates a message. `auto` means the model can pick between generating a message or calling a function.
    /// </summary>
    public enum CreateChatCompletionRequestFunctionCall
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

    public static class CreateChatCompletionRequestFunctionCallExtensions
    {
        public static string ToValueString(this CreateChatCompletionRequestFunctionCall value)
        {
            return value switch
            {
                CreateChatCompletionRequestFunctionCall.None => "none",
                CreateChatCompletionRequestFunctionCall.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateChatCompletionRequestFunctionCall ToEnum(string value)
        {
            return value switch
            {
                "none" => CreateChatCompletionRequestFunctionCall.None,
                "auto" => CreateChatCompletionRequestFunctionCall.Auto,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateChatCompletionRequestFunctionCall ToEnum(int value)
        {
            return value switch
            {
                0 => CreateChatCompletionRequestFunctionCall.None,
                1 => CreateChatCompletionRequestFunctionCall.Auto,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}