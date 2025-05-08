//HintName: G.Models.EvalScoreModelGraderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `score_model`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EvalScoreModelGraderType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="score_model")]
        ScoreModel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalScoreModelGraderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalScoreModelGraderType value)
        {
            return value switch
            {
                EvalScoreModelGraderType.ScoreModel => "score_model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalScoreModelGraderType? ToEnum(string value)
        {
            return value switch
            {
                "score_model" => EvalScoreModelGraderType.ScoreModel,
                _ => null,
            };
        }
    }
}