//HintName: G.Models.ChatPromptMessageDiscriminatorRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatPromptMessageDiscriminatorRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="developer")]
        Developer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="placeholder")]
        Placeholder,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="system")]
        System,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
        Tool,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
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