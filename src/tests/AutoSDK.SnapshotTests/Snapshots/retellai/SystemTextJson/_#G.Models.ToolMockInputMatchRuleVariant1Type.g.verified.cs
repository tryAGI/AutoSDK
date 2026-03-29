//HintName: G.Models.ToolMockInputMatchRuleVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Match any input of the tool
    /// </summary>
    public enum ToolMockInputMatchRuleVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Any,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolMockInputMatchRuleVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolMockInputMatchRuleVariant1Type value)
        {
            return value switch
            {
                ToolMockInputMatchRuleVariant1Type.Any => "any",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolMockInputMatchRuleVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "any" => ToolMockInputMatchRuleVariant1Type.Any,
                _ => null,
            };
        }
    }
}