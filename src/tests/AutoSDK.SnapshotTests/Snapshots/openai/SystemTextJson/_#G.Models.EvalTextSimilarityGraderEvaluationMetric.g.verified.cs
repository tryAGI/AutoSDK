//HintName: G.Models.EvalTextSimilarityGraderEvaluationMetric.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The evaluation metric to use. One of `fuzzy_match`, `bleu`, `gleu`, `meteor`, `rouge_1`, `rouge_2`, `rouge_3`, `rouge_4`, `rouge_5`, or `rouge_l`.
    /// </summary>
    public enum EvalTextSimilarityGraderEvaluationMetric
    {
        /// <summary>
        /// 
        /// </summary>
        FuzzyMatch,
        /// <summary>
        /// 
        /// </summary>
        Bleu,
        /// <summary>
        /// 
        /// </summary>
        Gleu,
        /// <summary>
        /// 
        /// </summary>
        Meteor,
        /// <summary>
        /// 
        /// </summary>
        Rouge1,
        /// <summary>
        /// 
        /// </summary>
        Rouge2,
        /// <summary>
        /// 
        /// </summary>
        Rouge3,
        /// <summary>
        /// 
        /// </summary>
        Rouge4,
        /// <summary>
        /// 
        /// </summary>
        Rouge5,
        /// <summary>
        /// 
        /// </summary>
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