//HintName: G.Models.NodeInstructionPromptType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of instruction
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum NodeInstructionPromptType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompt")]
        Prompt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NodeInstructionPromptTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NodeInstructionPromptType value)
        {
            return value switch
            {
                NodeInstructionPromptType.Prompt => "prompt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NodeInstructionPromptType? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => NodeInstructionPromptType.Prompt,
                _ => null,
            };
        }
    }
}