//HintName: G.Models.EvaluatorItemWriteType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EvaluatorItemWriteType
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
    public static class EvaluatorItemWriteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluatorItemWriteType value)
        {
            return value switch
            {
                EvaluatorItemWriteType.CodeMetric => "code_metric",
                EvaluatorItemWriteType.LlmJudge => "llm_judge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluatorItemWriteType? ToEnum(string value)
        {
            return value switch
            {
                "code_metric" => EvaluatorItemWriteType.CodeMetric,
                "llm_judge" => EvaluatorItemWriteType.LlmJudge,
                _ => null,
            };
        }
    }
}