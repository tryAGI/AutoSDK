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
        User,
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        Tool,
        /// <summary>
        /// 
        /// </summary>
        System,
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
                LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole.User => "user",
                LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole.Assistant => "assistant",
                LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole.Tool => "tool",
                LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole.System => "system",
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
                "user" => LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole.User,
                "assistant" => LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole.Assistant,
                "tool" => LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole.Tool,
                "system" => LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole.System,
                _ => null,
            };
        }
    }
}