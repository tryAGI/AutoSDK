//HintName: G.Models.GetReportScoreResponseScoreScoreType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of scoring used for this report
    /// </summary>
    public enum GetReportScoreResponseScoreScoreType
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        MultiColumn,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        SingleColumn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetReportScoreResponseScoreScoreTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetReportScoreResponseScoreScoreType value)
        {
            return value switch
            {
                GetReportScoreResponseScoreScoreType.Custom => "custom",
                GetReportScoreResponseScoreScoreType.MultiColumn => "multi_column",
                GetReportScoreResponseScoreScoreType.None => "none",
                GetReportScoreResponseScoreScoreType.SingleColumn => "single_column",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetReportScoreResponseScoreScoreType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => GetReportScoreResponseScoreScoreType.Custom,
                "multi_column" => GetReportScoreResponseScoreScoreType.MultiColumn,
                "none" => GetReportScoreResponseScoreScoreType.None,
                "single_column" => GetReportScoreResponseScoreScoreType.SingleColumn,
                _ => null,
            };
        }
    }
}