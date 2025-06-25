//HintName: G.Models.DashboardCriteriaChartModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: criteria
    /// </summary>
    public enum DashboardCriteriaChartModelType
    {
        /// <summary>
        /// 
        /// </summary>
        Criteria,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DashboardCriteriaChartModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DashboardCriteriaChartModelType value)
        {
            return value switch
            {
                DashboardCriteriaChartModelType.Criteria => "criteria",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DashboardCriteriaChartModelType? ToEnum(string value)
        {
            return value switch
            {
                "criteria" => DashboardCriteriaChartModelType.Criteria,
                _ => null,
            };
        }
    }
}