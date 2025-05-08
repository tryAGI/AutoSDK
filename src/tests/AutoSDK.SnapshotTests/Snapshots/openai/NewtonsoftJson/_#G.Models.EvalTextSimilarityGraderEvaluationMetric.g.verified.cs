//HintName: G.Models.EvalTextSimilarityGraderEvaluationMetric.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The evaluation metric to use. One of `fuzzy_match`, `bleu`, `gleu`, `meteor`, `rouge_1`, `rouge_2`, `rouge_3`, `rouge_4`, `rouge_5`, or `rouge_l`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EvalTextSimilarityGraderEvaluationMetric
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fuzzy_match")]
        FuzzyMatch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bleu")]
        Bleu,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gleu")]
        Gleu,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="meteor")]
        Meteor,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rouge_1")]
        Rouge1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rouge_2")]
        Rouge2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rouge_3")]
        Rouge3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rouge_4")]
        Rouge4,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rouge_5")]
        Rouge5,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rouge_l")]
        RougeL,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalTextSimilarityGraderEvaluationMetricExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalTextSimilarityGraderEvaluationMetric value)
        {
            return value switch
            {
                EvalTextSimilarityGraderEvaluationMetric.FuzzyMatch => "fuzzy_match",
                EvalTextSimilarityGraderEvaluationMetric.Bleu => "bleu",
                EvalTextSimilarityGraderEvaluationMetric.Gleu => "gleu",
                EvalTextSimilarityGraderEvaluationMetric.Meteor => "meteor",
                EvalTextSimilarityGraderEvaluationMetric.Rouge1 => "rouge_1",
                EvalTextSimilarityGraderEvaluationMetric.Rouge2 => "rouge_2",
                EvalTextSimilarityGraderEvaluationMetric.Rouge3 => "rouge_3",
                EvalTextSimilarityGraderEvaluationMetric.Rouge4 => "rouge_4",
                EvalTextSimilarityGraderEvaluationMetric.Rouge5 => "rouge_5",
                EvalTextSimilarityGraderEvaluationMetric.RougeL => "rouge_l",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalTextSimilarityGraderEvaluationMetric? ToEnum(string value)
        {
            return value switch
            {
                "fuzzy_match" => EvalTextSimilarityGraderEvaluationMetric.FuzzyMatch,
                "bleu" => EvalTextSimilarityGraderEvaluationMetric.Bleu,
                "gleu" => EvalTextSimilarityGraderEvaluationMetric.Gleu,
                "meteor" => EvalTextSimilarityGraderEvaluationMetric.Meteor,
                "rouge_1" => EvalTextSimilarityGraderEvaluationMetric.Rouge1,
                "rouge_2" => EvalTextSimilarityGraderEvaluationMetric.Rouge2,
                "rouge_3" => EvalTextSimilarityGraderEvaluationMetric.Rouge3,
                "rouge_4" => EvalTextSimilarityGraderEvaluationMetric.Rouge4,
                "rouge_5" => EvalTextSimilarityGraderEvaluationMetric.Rouge5,
                "rouge_l" => EvalTextSimilarityGraderEvaluationMetric.RougeL,
                _ => null,
            };
        }
    }
}