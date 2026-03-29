//HintName: G.Models.EvalResultsScorerStatsValueType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EvalResultsScorerStatsValueType2
    {
        /// <summary>
        /// 
        /// </summary>
        Binary,
        /// <summary>
        /// 
        /// </summary>
        Continuous,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalResultsScorerStatsValueType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalResultsScorerStatsValueType2 value)
        {
            return value switch
            {
                EvalResultsScorerStatsValueType2.Binary => "binary",
                EvalResultsScorerStatsValueType2.Continuous => "continuous",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalResultsScorerStatsValueType2? ToEnum(string value)
        {
            return value switch
            {
                "binary" => EvalResultsScorerStatsValueType2.Binary,
                "continuous" => EvalResultsScorerStatsValueType2.Continuous,
                _ => null,
            };
        }
    }
}