//HintName: G.Models.PromptMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ai")]
        Ai,
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
        [global::System.Runtime.Serialization.EnumMember(Value="model")]
        Model,
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
    public static class PromptMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptMessageRole value)
        {
            return value switch
            {
                PromptMessageRole.Ai => "ai",
                PromptMessageRole.Assistant => "assistant",
                PromptMessageRole.Developer => "developer",
                PromptMessageRole.Model => "model",
                PromptMessageRole.System => "system",
                PromptMessageRole.Tool => "tool",
                PromptMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "ai" => PromptMessageRole.Ai,
                "assistant" => PromptMessageRole.Assistant,
                "developer" => PromptMessageRole.Developer,
                "model" => PromptMessageRole.Model,
                "system" => PromptMessageRole.System,
                "tool" => PromptMessageRole.Tool,
                "user" => PromptMessageRole.User,
                _ => null,
            };
        }
    }
}