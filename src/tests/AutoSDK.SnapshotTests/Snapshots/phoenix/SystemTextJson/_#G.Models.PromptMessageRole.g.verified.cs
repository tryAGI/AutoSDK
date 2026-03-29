//HintName: G.Models.PromptMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Ai,
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
        Model,
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