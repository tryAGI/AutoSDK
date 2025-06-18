//HintName: G.Models.GraderTextSimilarityEvaluationMetric.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The evaluation metric to use. One of `fuzzy_match`, `bleu`, `gleu`, `meteor`, `rouge_1`, `rouge_2`, `rouge_3`, `rouge_4`, `rouge_5`, or `rouge_l`.
    /// </summary>
    public enum GraderTextSimilarityEvaluationMetric
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
    public static class GraderTextSimilarityEvaluationMetricExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GraderTextSimilarityEvaluationMetric value)
        {
            return value switch
            {
                GraderTextSimilarityEvaluationMetric.FuzzyMatch => "fuzzy_match",
                GraderTextSimilarityEvaluationMetric.Bleu => "bleu",
                GraderTextSimilarityEvaluationMetric.Gleu => "gleu",
                GraderTextSimilarityEvaluationMetric.Meteor => "meteor",
                GraderTextSimilarityEvaluationMetric.Rouge1 => "rouge_1",
                GraderTextSimilarityEvaluationMetric.Rouge2 => "rouge_2",
                GraderTextSimilarityEvaluationMetric.Rouge3 => "rouge_3",
                GraderTextSimilarityEvaluationMetric.Rouge4 => "rouge_4",
                GraderTextSimilarityEvaluationMetric.Rouge5 => "rouge_5",
                GraderTextSimilarityEvaluationMetric.RougeL => "rouge_l",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GraderTextSimilarityEvaluationMetric? ToEnum(string value)
        {
            return value switch
            {
                "fuzzy_match" => GraderTextSimilarityEvaluationMetric.FuzzyMatch,
                "bleu" => GraderTextSimilarityEvaluationMetric.Bleu,
                "gleu" => GraderTextSimilarityEvaluationMetric.Gleu,
                "meteor" => GraderTextSimilarityEvaluationMetric.Meteor,
                "rouge_1" => GraderTextSimilarityEvaluationMetric.Rouge1,
                "rouge_2" => GraderTextSimilarityEvaluationMetric.Rouge2,
                "rouge_3" => GraderTextSimilarityEvaluationMetric.Rouge3,
                "rouge_4" => GraderTextSimilarityEvaluationMetric.Rouge4,
                "rouge_5" => GraderTextSimilarityEvaluationMetric.Rouge5,
                "rouge_l" => GraderTextSimilarityEvaluationMetric.RougeL,
                _ => null,
            };
        }
    }
}