//HintName: G.Models.ChatCompletionRequestToolChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls tool invocation: none, auto, required
    /// </summary>
    public enum ChatCompletionRequestToolChoice
    {
        /// <summary>
        /// none, auto, required
        /// </summary>
        Auto,
        /// <summary>
        /// none, auto, required
        /// </summary>
        None,
        /// <summary>
        /// none, auto, required
        /// </summary>
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestToolChoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestToolChoice value)
        {
            return value switch
            {
                ChatCompletionRequestToolChoice.Auto => "auto",
                ChatCompletionRequestToolChoice.None => "none",
                ChatCompletionRequestToolChoice.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestToolChoice? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ChatCompletionRequestToolChoice.Auto,
                "none" => ChatCompletionRequestToolChoice.None,
                "required" => ChatCompletionRequestToolChoice.Required,
                _ => null,
            };
        }
    }
}