//HintName: G.Models.ChatCompletionRequestMessageContentPartRefusalType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the content part.
    /// </summary>
    public enum ChatCompletionRequestMessageContentPartRefusalType
    {
        /// <summary>
        /// 
        /// </summary>
        Refusal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestMessageContentPartRefusalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestMessageContentPartRefusalType value)
        {
            return value switch
            {
                ChatCompletionRequestMessageContentPartRefusalType.Refusal => "refusal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestMessageContentPartRefusalType? ToEnum(string value)
        {
            return value switch
            {
                "refusal" => ChatCompletionRequestMessageContentPartRefusalType.Refusal,
                _ => null,
            };
        }
    }
}