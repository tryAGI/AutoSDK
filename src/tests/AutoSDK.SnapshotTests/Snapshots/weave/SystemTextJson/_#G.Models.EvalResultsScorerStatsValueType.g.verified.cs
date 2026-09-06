//HintName: G.Models.EvalResultsScorerStatsValueType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EvalResultsScorerStatsValueType
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
    public static class EvalResultsScorerStatsValueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalResultsScorerStatsValueType value)
        {
            return value switch
            {
                EvalResultsScorerStatsValueType.Binary => "binary",
                EvalResultsScorerStatsValueType.Continuous => "continuous",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalResultsScorerStatsValueType? ToEnum(string value)
        {
            return value switch
            {
                "binary" => EvalResultsScorerStatsValueType.Binary,
                "continuous" => EvalResultsScorerStatsValueType.Continuous,
                _ => null,
            };
        }
    }
}