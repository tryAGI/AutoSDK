//HintName: G.Models.ChatPromptMessageDiscriminatorRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatPromptMessageDiscriminatorRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        Developer,
        /// <summary>
        /// 
        /// </summary>
        Function,
        /// <summary>
        /// 
        /// </summary>
        Placeholder,
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
    public static class ChatPromptMessageDiscriminatorRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatPromptMessageDiscriminatorRole value)
        {
            return value switch
            {
                ChatPromptMessageDiscriminatorRole.Assistant => "assistant",
                ChatPromptMessageDiscriminatorRole.Developer => "developer",
                ChatPromptMessageDiscriminatorRole.Function => "function",
                ChatPromptMessageDiscriminatorRole.Placeholder => "placeholder",
                ChatPromptMessageDiscriminatorRole.System => "system",
                ChatPromptMessageDiscriminatorRole.Tool => "tool",
                ChatPromptMessageDiscriminatorRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatPromptMessageDiscriminatorRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatPromptMessageDiscriminatorRole.Assistant,
                "developer" => ChatPromptMessageDiscriminatorRole.Developer,
                "function" => ChatPromptMessageDiscriminatorRole.Function,
                "placeholder" => ChatPromptMessageDiscriminatorRole.Placeholder,
                "system" => ChatPromptMessageDiscriminatorRole.System,
                "tool" => ChatPromptMessageDiscriminatorRole.Tool,
                "user" => ChatPromptMessageDiscriminatorRole.User,
                _ => null,
            };
        }
    }
}