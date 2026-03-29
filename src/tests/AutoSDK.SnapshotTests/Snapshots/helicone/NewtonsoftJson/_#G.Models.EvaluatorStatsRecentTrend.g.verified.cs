//HintName: G.Models.EvaluatorStatsRecentTrend.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EvaluatorStatsRecentTrend
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="down")]
        Down,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stable")]
        Stable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="up")]
        Up,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluatorStatsRecentTrendExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluatorStatsRecentTrend value)
        {
            return value switch
            {
                EvaluatorStatsRecentTrend.Down => "down",
                EvaluatorStatsRecentTrend.Stable => "stable",
                EvaluatorStatsRecentTrend.Up => "up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluatorStatsRecentTrend? ToEnum(string value)
        {
            return value switch
            {
                "down" => EvaluatorStatsRecentTrend.Down,
                "stable" => EvaluatorStatsRecentTrend.Stable,
                "up" => EvaluatorStatsRecentTrend.Up,
                _ => null,
            };
        }
    }
}