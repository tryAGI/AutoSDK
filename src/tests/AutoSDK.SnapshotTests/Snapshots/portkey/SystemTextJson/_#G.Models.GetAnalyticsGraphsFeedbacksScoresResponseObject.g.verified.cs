//HintName: G.Models.GetAnalyticsGraphsFeedbacksScoresResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of object being returned
    /// </summary>
    public enum GetAnalyticsGraphsFeedbacksScoresResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        AnalyticsGraph,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAnalyticsGraphsFeedbacksScoresResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsGraphsFeedbacksScoresResponseObject value)
        {
            return value switch
            {
                GetAnalyticsGraphsFeedbacksScoresResponseObject.AnalyticsGraph => "analytics-graph",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsGraphsFeedbacksScoresResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "analytics-graph" => GetAnalyticsGraphsFeedbacksScoresResponseObject.AnalyticsGraph,
                _ => null,
            };
        }
    }
}