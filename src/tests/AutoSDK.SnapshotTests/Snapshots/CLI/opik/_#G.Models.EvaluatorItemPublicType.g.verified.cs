//HintName: G.Models.EvaluatorItemPublicType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EvaluatorItemPublicType
    {
        /// <summary>
        /// 
        /// </summary>
        CodeMetric,
        /// <summary>
        /// 
        /// </summary>
        LlmJudge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluatorItemPublicTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluatorItemPublicType value)
        {
            return value switch
            {
                EvaluatorItemPublicType.CodeMetric => "code_metric",
                EvaluatorItemPublicType.LlmJudge => "llm_judge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluatorItemPublicType? ToEnum(string value)
        {
            return value switch
            {
                "code_metric" => EvaluatorItemPublicType.CodeMetric,
                "llm_judge" => EvaluatorItemPublicType.LlmJudge,
                _ => null,
            };
        }
    }
}