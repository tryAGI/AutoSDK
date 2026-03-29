//HintName: G.Models.CreateChatCompletionRequestToolChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls which tool is called by the model.
    /// </summary>
    public enum CreateChatCompletionRequestToolChoice
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionRequestToolChoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionRequestToolChoice value)
        {
            return value switch
            {
                CreateChatCompletionRequestToolChoice.Auto => "auto",
                CreateChatCompletionRequestToolChoice.None => "none",
                CreateChatCompletionRequestToolChoice.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionRequestToolChoice? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateChatCompletionRequestToolChoice.Auto,
                "none" => CreateChatCompletionRequestToolChoice.None,
                "tool" => CreateChatCompletionRequestToolChoice.Tool,
                _ => null,
            };
        }
    }
}