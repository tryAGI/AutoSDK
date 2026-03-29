//HintName: G.Models.LlmToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool.
    /// </summary>
    public enum LlmToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Llm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LlmToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LlmToolType value)
        {
            return value switch
            {
                LlmToolType.Llm => "llm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LlmToolType? ToEnum(string value)
        {
            return value switch
            {
                "llm" => LlmToolType.Llm,
                _ => null,
            };
        }
    }
}