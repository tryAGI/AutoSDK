//HintName: G.Models.EvaluatorItemType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EvaluatorItemType
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
    public static class EvaluatorItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluatorItemType value)
        {
            return value switch
            {
                EvaluatorItemType.CodeMetric => "code_metric",
                EvaluatorItemType.LlmJudge => "llm_judge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluatorItemType? ToEnum(string value)
        {
            return value switch
            {
                "code_metric" => EvaluatorItemType.CodeMetric,
                "llm_judge" => EvaluatorItemType.LlmJudge,
                _ => null,
            };
        }
    }
}