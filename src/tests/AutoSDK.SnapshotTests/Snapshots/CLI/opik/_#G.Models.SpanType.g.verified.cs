//HintName: G.Models.SpanType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpanType
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
    public static class SpanTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanType value)
        {
            return value switch
            {
                SpanType.General => "general",
                SpanType.Guardrail => "guardrail",
                SpanType.Llm => "llm",
                SpanType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanType? ToEnum(string value)
        {
            return value switch
            {
                "general" => SpanType.General,
                "guardrail" => SpanType.Guardrail,
                "llm" => SpanType.Llm,
                "tool" => SpanType.Tool,
                _ => null,
            };
        }
    }
}