//HintName: G.Models.SpanUpdateType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpanUpdateType
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
    public static class SpanUpdateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanUpdateType value)
        {
            return value switch
            {
                SpanUpdateType.General => "general",
                SpanUpdateType.Guardrail => "guardrail",
                SpanUpdateType.Llm => "llm",
                SpanUpdateType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanUpdateType? ToEnum(string value)
        {
            return value switch
            {
                "general" => SpanUpdateType.General,
                "guardrail" => SpanUpdateType.Guardrail,
                "llm" => SpanUpdateType.Llm,
                "tool" => SpanUpdateType.Tool,
                _ => null,
            };
        }
    }
}