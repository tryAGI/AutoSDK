//HintName: G.Models.GetAnalyticsGraphsRequestsResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of object being returned
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAnalyticsGraphsRequestsResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="analytics-graph")]
        AnalyticsGraph,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAnalyticsGraphsRequestsResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsGraphsRequestsResponseObject value)
        {
            return value switch
            {
                GetAnalyticsGraphsRequestsResponseObject.AnalyticsGraph => "analytics-graph",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsGraphsRequestsResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "analytics-graph" => GetAnalyticsGraphsRequestsResponseObject.AnalyticsGraph,
                _ => null,
            };
        }
    }
}