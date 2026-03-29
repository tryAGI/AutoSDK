//HintName: G.Models.EvaluatorItemCompareType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EvaluatorItemCompareType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code_metric")]
        CodeMetric,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llm_judge")]
        LlmJudge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluatorItemCompareTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluatorItemCompareType value)
        {
            return value switch
            {
                EvaluatorItemCompareType.CodeMetric => "code_metric",
                EvaluatorItemCompareType.LlmJudge => "llm_judge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluatorItemCompareType? ToEnum(string value)
        {
            return value switch
            {
                "code_metric" => EvaluatorItemCompareType.CodeMetric,
                "llm_judge" => EvaluatorItemCompareType.LlmJudge,
                _ => null,
            };
        }
    }
}