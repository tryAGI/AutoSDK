//HintName: G.Models.GetAnalyticsGraphsFeedbacksResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of object being returned
    /// </summary>
    public enum GetAnalyticsGraphsFeedbacksResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        AnalyticsGraph,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAnalyticsGraphsFeedbacksResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsGraphsFeedbacksResponseObject value)
        {
            return value switch
            {
                GetAnalyticsGraphsFeedbacksResponseObject.AnalyticsGraph => "analytics-graph",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsGraphsFeedbacksResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "analytics-graph" => GetAnalyticsGraphsFeedbacksResponseObject.AnalyticsGraph,
                _ => null,
            };
        }
    }
}