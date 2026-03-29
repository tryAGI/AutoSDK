//HintName: G.Models.ToolMockInputMatchRuleVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Match only calls with specific arguments
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ToolMockInputMatchRuleVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="partial_match")]
        PartialMatch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolMockInputMatchRuleVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolMockInputMatchRuleVariant2Type value)
        {
            return value switch
            {
                ToolMockInputMatchRuleVariant2Type.PartialMatch => "partial_match",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolMockInputMatchRuleVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "partial_match" => ToolMockInputMatchRuleVariant2Type.PartialMatch,
                _ => null,
            };
        }
    }
}