//HintName: G.Models.SpanWriteType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpanWriteType
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
    public static class SpanWriteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanWriteType value)
        {
            return value switch
            {
                SpanWriteType.General => "general",
                SpanWriteType.Guardrail => "guardrail",
                SpanWriteType.Llm => "llm",
                SpanWriteType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanWriteType? ToEnum(string value)
        {
            return value switch
            {
                "general" => SpanWriteType.General,
                "guardrail" => SpanWriteType.Guardrail,
                "llm" => SpanWriteType.Llm,
                "tool" => SpanWriteType.Tool,
                _ => null,
            };
        }
    }
}