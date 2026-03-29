//HintName: G.Models.GetAnalyticsGraphsErrorsStacksResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of object being returned
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAnalyticsGraphsErrorsStacksResponseObject
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
    public static class GetAnalyticsGraphsErrorsStacksResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsGraphsErrorsStacksResponseObject value)
        {
            return value switch
            {
                GetAnalyticsGraphsErrorsStacksResponseObject.AnalyticsGraph => "analytics-graph",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsGraphsErrorsStacksResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "analytics-graph" => GetAnalyticsGraphsErrorsStacksResponseObject.AnalyticsGraph,
                _ => null,
            };
        }
    }
}