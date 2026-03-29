//HintName: G.Models.SpanExperimentItemBulkWriteViewType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpanExperimentItemBulkWriteViewType
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
    public static class SpanExperimentItemBulkWriteViewTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanExperimentItemBulkWriteViewType value)
        {
            return value switch
            {
                SpanExperimentItemBulkWriteViewType.General => "general",
                SpanExperimentItemBulkWriteViewType.Guardrail => "guardrail",
                SpanExperimentItemBulkWriteViewType.Llm => "llm",
                SpanExperimentItemBulkWriteViewType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanExperimentItemBulkWriteViewType? ToEnum(string value)
        {
            return value switch
            {
                "general" => SpanExperimentItemBulkWriteViewType.General,
                "guardrail" => SpanExperimentItemBulkWriteViewType.Guardrail,
                "llm" => SpanExperimentItemBulkWriteViewType.Llm,
                "tool" => SpanExperimentItemBulkWriteViewType.Tool,
                _ => null,
            };
        }
    }
}