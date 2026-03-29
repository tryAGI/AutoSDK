//HintName: G.Models.GetAnalyticsGraphsUsersRequestsResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of object being returned
    /// </summary>
    public enum GetAnalyticsGraphsUsersRequestsResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        AnalyticsGraph,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAnalyticsGraphsUsersRequestsResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsGraphsUsersRequestsResponseObject value)
        {
            return value switch
            {
                GetAnalyticsGraphsUsersRequestsResponseObject.AnalyticsGraph => "analytics-graph",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsGraphsUsersRequestsResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "analytics-graph" => GetAnalyticsGraphsUsersRequestsResponseObject.AnalyticsGraph,
                _ => null,
            };
        }
    }
}