//HintName: G.Models.GetAnalyticsGraphsUsersResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of object being returned
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAnalyticsGraphsUsersResponseObject
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
    public static class GetAnalyticsGraphsUsersResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsGraphsUsersResponseObject value)
        {
            return value switch
            {
                GetAnalyticsGraphsUsersResponseObject.AnalyticsGraph => "analytics-graph",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsGraphsUsersResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "analytics-graph" => GetAnalyticsGraphsUsersResponseObject.AnalyticsGraph,
                _ => null,
            };
        }
    }
}