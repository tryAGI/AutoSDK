//HintName: G.Models.LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        Tool,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole value)
        {
            return value switch
            {
                LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole.Assistant => "assistant",
                LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole.System => "system",
                LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole.Tool => "tool",
                LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole.Assistant,
                "system" => LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole.System,
                "tool" => LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole.Tool,
                "user" => LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole.User,
                _ => null,
            };
        }
    }
}