//HintName: G.Models.GetSpanStatsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSpanStatsType
    {
        /// <summary>
        /// 
        /// </summary>
        General,
        /// <summary>
        /// 
        /// </summary>
        Guardrail,
        /// <summary>
        /// 
        /// </summary>
        Llm,
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSpanStatsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpanStatsType value)
        {
            return value switch
            {
                GetSpanStatsType.General => "general",
                GetSpanStatsType.Guardrail => "guardrail",
                GetSpanStatsType.Llm => "llm",
                GetSpanStatsType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpanStatsType? ToEnum(string value)
        {
            return value switch
            {
                "general" => GetSpanStatsType.General,
                "guardrail" => GetSpanStatsType.Guardrail,
                "llm" => GetSpanStatsType.Llm,
                "tool" => GetSpanStatsType.Tool,
                _ => null,
            };
        }
    }
}