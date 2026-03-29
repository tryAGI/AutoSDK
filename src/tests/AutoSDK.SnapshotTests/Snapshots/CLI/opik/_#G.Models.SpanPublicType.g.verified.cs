//HintName: G.Models.SpanPublicType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpanPublicType
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
    public static class SpanPublicTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanPublicType value)
        {
            return value switch
            {
                SpanPublicType.General => "general",
                SpanPublicType.Guardrail => "guardrail",
                SpanPublicType.Llm => "llm",
                SpanPublicType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanPublicType? ToEnum(string value)
        {
            return value switch
            {
                "general" => SpanPublicType.General,
                "guardrail" => SpanPublicType.Guardrail,
                "llm" => SpanPublicType.Llm,
                "tool" => SpanPublicType.Tool,
                _ => null,
            };
        }
    }
}