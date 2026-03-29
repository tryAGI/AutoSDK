//HintName: G.Models.RecommendStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How to use positive and negative examples to find the results, default is `average_vector`:<br/>
    /// * `average_vector` - Average positive and negative vectors and create a single query with the formula `query = avg_pos + avg_pos - avg_neg`. Then performs normal search.<br/>
    /// * `best_score` - Uses custom search objective. Each candidate is compared against all examples, its score is then chosen from the `max(max_pos_score, max_neg_score)`. If the `max_neg_score` is chosen then it is squared and negated, otherwise it is just the `max_pos_score`.<br/>
    /// * `sum_scores` - Uses custom search objective. Compares against all inputs, sums all the scores. Scores against positive vectors are added, against negatives are subtracted.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RecommendStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="average_vector")]
        AverageVector,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="best_score")]
        BestScore,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sum_scores")]
        SumScores,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RecommendStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RecommendStrategy value)
        {
            return value switch
            {
                RecommendStrategy.AverageVector => "average_vector",
                RecommendStrategy.BestScore => "best_score",
                RecommendStrategy.SumScores => "sum_scores",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RecommendStrategy? ToEnum(string value)
        {
            return value switch
            {
                "average_vector" => RecommendStrategy.AverageVector,
                "best_score" => RecommendStrategy.BestScore,
                "sum_scores" => RecommendStrategy.SumScores,
                _ => null,
            };
        }
    }
}