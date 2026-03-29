//HintName: G.Models.CreateChatPromptType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateChatPromptType
    {
        /// <summary>
        /// 
        /// </summary>
        Chat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatPromptTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatPromptType value)
        {
            return value switch
            {
                CreateChatPromptType.Chat => "chat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatPromptType? ToEnum(string value)
        {
            return value switch
            {
                "chat" => CreateChatPromptType.Chat,
                _ => null,
            };
        }
    }
}