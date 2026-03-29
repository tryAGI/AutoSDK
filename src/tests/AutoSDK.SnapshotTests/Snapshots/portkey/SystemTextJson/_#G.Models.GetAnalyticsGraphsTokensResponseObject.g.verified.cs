//HintName: G.Models.GetAnalyticsGraphsTokensResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of object being returned
    /// </summary>
    public enum GetAnalyticsGraphsTokensResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        AnalyticsGraph,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAnalyticsGraphsTokensResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsGraphsTokensResponseObject value)
        {
            return value switch
            {
                GetAnalyticsGraphsTokensResponseObject.AnalyticsGraph => "analytics-graph",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsGraphsTokensResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "analytics-graph" => GetAnalyticsGraphsTokensResponseObject.AnalyticsGraph,
                _ => null,
            };
        }
    }
}