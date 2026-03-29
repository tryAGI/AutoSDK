//HintName: G.Models.NodeInstructionStaticTextType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of instruction
    /// </summary>
    public enum NodeInstructionStaticTextType
    {
        /// <summary>
        /// 
        /// </summary>
        StaticText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NodeInstructionStaticTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NodeInstructionStaticTextType value)
        {
            return value switch
            {
                NodeInstructionStaticTextType.StaticText => "static_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NodeInstructionStaticTextType? ToEnum(string value)
        {
            return value switch
            {
                "static_text" => NodeInstructionStaticTextType.StaticText,
                _ => null,
            };
        }
    }
}