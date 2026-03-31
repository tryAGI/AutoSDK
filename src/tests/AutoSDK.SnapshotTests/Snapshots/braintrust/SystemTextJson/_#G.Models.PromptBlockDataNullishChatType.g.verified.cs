//HintName: G.Models.PromptBlockDataNullishChatType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptBlockDataNullishChatType
    {
        /// <summary>
        /// 
        /// </summary>
        Chat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptBlockDataNullishChatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptBlockDataNullishChatType value)
        {
            return value switch
            {
                PromptBlockDataNullishChatType.Chat => "chat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptBlockDataNullishChatType? ToEnum(string value)
        {
            return value switch
            {
                "chat" => PromptBlockDataNullishChatType.Chat,
                _ => null,
            };
        }
    }
}