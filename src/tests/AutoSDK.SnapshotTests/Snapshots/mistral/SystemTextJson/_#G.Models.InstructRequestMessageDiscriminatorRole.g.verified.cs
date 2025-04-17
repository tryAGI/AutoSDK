//HintName: G.Models.InstructRequestMessageDiscriminatorRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum InstructRequestMessageDiscriminatorRole
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
    public static class InstructRequestMessageDiscriminatorRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InstructRequestMessageDiscriminatorRole value)
        {
            return value switch
            {
                InstructRequestMessageDiscriminatorRole.Assistant => "assistant",
                InstructRequestMessageDiscriminatorRole.System => "system",
                InstructRequestMessageDiscriminatorRole.Tool => "tool",
                InstructRequestMessageDiscriminatorRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InstructRequestMessageDiscriminatorRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => InstructRequestMessageDiscriminatorRole.Assistant,
                "system" => InstructRequestMessageDiscriminatorRole.System,
                "tool" => InstructRequestMessageDiscriminatorRole.Tool,
                "user" => InstructRequestMessageDiscriminatorRole.User,
                _ => null,
            };
        }
    }
}