//HintName: G.Models.PromptBlockDataChatType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptBlockDataChatType
    {
        /// <summary>
        /// 
        /// </summary>
        Chat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptBlockDataChatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptBlockDataChatType value)
        {
            return value switch
            {
                PromptBlockDataChatType.Chat => "chat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptBlockDataChatType? ToEnum(string value)
        {
            return value switch
            {
                "chat" => PromptBlockDataChatType.Chat,
                _ => null,
            };
        }
    }
}