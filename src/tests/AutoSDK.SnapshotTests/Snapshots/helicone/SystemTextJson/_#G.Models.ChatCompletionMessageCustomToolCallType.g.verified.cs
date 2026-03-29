//HintName: G.Models.ChatCompletionMessageCustomToolCallType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the tool. Always `custom`.
    /// </summary>
    public enum ChatCompletionMessageCustomToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionMessageCustomToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionMessageCustomToolCallType value)
        {
            return value switch
            {
                ChatCompletionMessageCustomToolCallType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionMessageCustomToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => ChatCompletionMessageCustomToolCallType.Custom,
                _ => null,
            };
        }
    }
}