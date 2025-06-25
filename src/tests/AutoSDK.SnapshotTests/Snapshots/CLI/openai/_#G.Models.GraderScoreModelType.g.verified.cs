//HintName: G.Models.GraderScoreModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `score_model`.
    /// </summary>
    public enum GraderScoreModelType
    {
        /// <summary>
        /// 
        /// </summary>
        ScoreModel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GraderScoreModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GraderScoreModelType value)
        {
            return value switch
            {
                GraderScoreModelType.ScoreModel => "score_model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GraderScoreModelType? ToEnum(string value)
        {
            return value switch
            {
                "score_model" => GraderScoreModelType.ScoreModel,
                _ => null,
            };
        }
    }
}