//HintName: G.Models.LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
        Tool,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="system")]
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